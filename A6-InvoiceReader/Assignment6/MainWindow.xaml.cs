using Microsoft.Win32;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Assignment6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Invoice loadedInvoice;


        public MainWindow()
        {
            InitializeComponent();
            Canvas.Visibility = Visibility.Hidden;
        }


        /// <summary>
        /// Opens a file dialoge to let the user choose an invoice to open
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenInvoice_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Open Invoice";
            dialog.Filter = "Text files|*.txt";
            dialog.InitialDirectory = InvoicesDataPath;

            bool? result = dialog.ShowDialog();
            if (result == true)
            {
                LoadFile(dialog.FileName);
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }


        private void DiscountPercentage_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (loadedInvoice != null)
                CalculateDiscountedTotal();
        }



        private string InvoicesDataPath   //Creates a relative path to a prederermined folder with Invoices
        {
            get
            {
#if DEBUG
                int trimcount = 10;
#else
                int trimcount = 12;
#endif
                string startupPath = System.AppDomain.CurrentDomain.BaseDirectory;
                string path = startupPath.Substring(0, startupPath.Length - trimcount) + "Invoices\\";
                return path;
            }
        }


        private void LoadFile(string path)
        {
            string[] lines = File.ReadAllLines(path);

            try
            {
                loadedInvoice = new Invoice(lines);
            }
            catch (System.FormatException e)
            {
                MessageBox.Show("The loaded invoice could not be read - incorrect format\n" + e.ToString(), "Exception");
                return;
            }
            catch (System.Exception e)
            {
                MessageBox.Show("The loaded invoice could not be read\n" + e.ToString(), "Exception");
                return;
            }

            ItemsList.Items.Clear();
            DiscountPercentage.Text = "0";

            CompanyName.Text = loadedInvoice.SenderContact.CompanyName;
            InvoiceNr.Text = loadedInvoice.InvoiceNr.ToString();
            InvoiceDate.Text = loadedInvoice.InvoiceDate;
            DueDate.Text = loadedInvoice.DueDate;

            RecieverBlock.Text = loadedInvoice.RecieverContact.CompanyName + "\n" +
                                 loadedInvoice.RecieverContact.PersonName + "\n" +
                                 loadedInvoice.RecieverContact.Address + "\n" +
                                 loadedInvoice.RecieverContact.Zipcode + "  " + loadedInvoice.RecieverContact.City + "\n" +
                                 loadedInvoice.RecieverContact.Country;

            for (int i = 0; i < loadedInvoice.Items.Length; i++)
            {
                ItemsList.Items.Add(loadedInvoice.Items[i]);
            }

            AddressBlock.Text = loadedInvoice.SenderContact.Address + "\n" +
                                loadedInvoice.SenderContact.Zipcode + "  " + loadedInvoice.SenderContact.City + "\n" +
                                loadedInvoice.SenderContact.Country;

            ContactBlock.Text = loadedInvoice.PhoneNr + "\n" +
                                loadedInvoice.WebPageURL;

            TotalSum.Text = loadedInvoice.Items.Sum(x => x.Total).ToString();
            CalculateDiscountedTotal();

            Canvas.Visibility = Visibility.Visible;
        }


        private void CalculateDiscountedTotal()
        {
            float discountPercentage = 0;
            float.TryParse(DiscountPercentage.Text, out discountPercentage);

            discountPercentage = (discountPercentage < 0.0f) ? 0.0f : discountPercentage;
            discountPercentage = (discountPercentage > 100.0f) ? 100.0f : discountPercentage;

            float total = loadedInvoice.Items.Sum(x => x.Total);
            DiscountedTotalSum.Text = (total * (1 - discountPercentage / 100)).ToString();
        }

    }

}
