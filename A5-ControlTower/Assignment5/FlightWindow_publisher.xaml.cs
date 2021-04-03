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

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="flightCode">The flight code chosen from the control tower subscriber</param>
        public FlightWindow_publisher(string flightCode)
        {
            InitializeComponent();

            Title = flightCode;
            SetRandomImg();
        }

        /// <summary>
        /// Sets the image to a random sub-image from the spritesheet of logos
        /// </summary>
        private void SetRandomImg()
        {
            int width = 177;    //  Total img width / 6 images
            int height = 133;   //  Total img height / 7 images
            int xPos = random.Next(0, 6) * width;
            int yPos = random.Next(0, 7) * height;
            CroppedBitmap cb = new CroppedBitmap(FlightImage.Source as BitmapSource, new Int32Rect(xPos, yPos, width, height));
            FlightImage.Source = cb;
        }

        /// <summary>
        /// Start flight button-event
        /// </summary>
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            FlightUpdated_EventArgs startEvent = new FlightUpdated_EventArgs(this.Title, "Started");
            OnFlightUpdated(startEvent);
        }

        /// <summary>
        /// ChangeRoute dropdown list-event
        /// </summary>
        private void ChangeRoute_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ChangeRoute != null && ChangeRoute.SelectedItem != null)
            {
                string dir = (ChangeRoute.SelectedItem as ComboBoxItem).Content.ToString();
                FlightUpdated_EventArgs changeRouteEvent = new FlightUpdated_EventArgs(this.Title, $"Now heading {dir} deg.");
                OnFlightUpdated(changeRouteEvent);
            }
        }

        /// <summary>
        /// Land flight button-event
        /// </summary>
        private void Land_Click(object sender, RoutedEventArgs e)
        {
            FlightUpdated_EventArgs landEvent = new FlightUpdated_EventArgs(this.Title, "Landing");
            OnFlightUpdated(landEvent);
        }

        public event EventHandler<FlightUpdated_EventArgs> FlightUpdate;


        /// <summary>
        /// Publishes <paramref name="e"/> to the FlightUpdate-event
        /// </summary>
        /// <param name="e"></param>
        public void OnFlightUpdated(FlightUpdated_EventArgs e)
        {
            FlightUpdate?.Invoke(this, e);
        }
    }

}
