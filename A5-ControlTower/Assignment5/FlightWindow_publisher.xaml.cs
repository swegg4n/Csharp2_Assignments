﻿using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Assignment5
{
    /// <summary>
    /// Interaction logic for FlightWindow.xaml
    /// </summary>
    public partial class FlightWindow_publisher : Window
    {
        public FlightWindow_publisher(string flightCode)
        {
            InitializeComponent();

            Title = flightCode;
        }


        private void Start_Click(object sender, RoutedEventArgs e)
        {
            FlightUpdated_EventArgs startEvent = new FlightUpdated_EventArgs();
            OnFlightUpdated(startEvent);
        }

        private void ChangeRoute_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FlightUpdated_EventArgs changeRouteEvent = new FlightUpdated_EventArgs();
            OnFlightUpdated(changeRouteEvent);
        }

        private void Land_Click(object sender, RoutedEventArgs e)
        {
            FlightUpdated_EventArgs landEvent = new FlightUpdated_EventArgs();
            OnFlightUpdated(landEvent);
        }

        public event EventHandler<EventArgs> flightChange;


        public void OnFlightUpdated(FlightUpdated_EventArgs e)
        {

        }
    }

}