using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadFile("F:/Programming/Csharp2_Assignments/A6-InvoiceReader/Assignment6/Invoices/Invoice_1.txt");
        }

        Invoice loadedInvoice;


        private void DiscountPercentage_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (loadedInvoice != null)
                CalculateDiscountTotal();
        }


        private void LoadFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            loadedInvoice = new Invoice(lines);

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
                                loadedInvoice.SenderContact.Zipcode + "  " + loadedInvoice.RecieverContact.City + "\n" +
                                loadedInvoice.SenderContact.Country;

            ContactBlock.Text = loadedInvoice.PhoneNr + "\n" +
                                loadedInvoice.WebPageURL;

            TotalSum.Text = loadedInvoice.Items.Sum(x => x.Total).ToString();
            CalculateDiscountTotal();
        }


        private void CalculateDiscountTotal()
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
