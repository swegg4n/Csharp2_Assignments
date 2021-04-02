using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Assignment5
{
    /// <summary>
    /// Interaction logic for FlightWindow.xaml
    /// </summary>
    public partial class FlightWindow_publisher : Window
    {
        Random random = new Random();

        public FlightWindow_publisher(string flightCode)
        {
            InitializeComponent();

            Title = flightCode;
            SetRandomImg();
        }

        private void SetRandomImg()
        {
            int width = 177;
            int height = 133;
            int xPos = random.Next(0, 6) * width;
            int yPos = random.Next(0, 7) * height;
            CroppedBitmap cb = new CroppedBitmap(FlightImage.Source as BitmapSource, new Int32Rect(xPos, yPos, width, height));
            FlightImage.Source = cb;
        }


        private void Start_Click(object sender, RoutedEventArgs e)
        {
            FlightUpdated_EventArgs startEvent = new FlightUpdated_EventArgs(this.Title, "Started");
            OnFlightUpdated(startEvent);
        }

        private void ChangeRoute_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ChangeRoute != null && ChangeRoute.SelectedItem != null)
            {
                string dir = (ChangeRoute.SelectedItem as ComboBoxItem).Content.ToString();
                FlightUpdated_EventArgs changeRouteEvent = new FlightUpdated_EventArgs(this.Title, $"Now heading {dir} deg.");
                OnFlightUpdated(changeRouteEvent);
            }
        }

        private void Land_Click(object sender, RoutedEventArgs e)
        {
            FlightUpdated_EventArgs landEvent = new FlightUpdated_EventArgs(this.Title, "Landing");
            OnFlightUpdated(landEvent);
        }

        public event EventHandler<FlightUpdated_EventArgs> FlightUpdate;


        public void OnFlightUpdated(FlightUpdated_EventArgs e)
        {
            FlightUpdate?.Invoke(this, e);
        }
    }

}
