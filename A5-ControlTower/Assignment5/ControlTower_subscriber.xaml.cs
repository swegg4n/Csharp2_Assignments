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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment5
{
    /// <summary>
    /// Interaction logic for ControlTower_subscriber.xaml
    /// </summary>
    public partial class ControlTower_subscriber : Window
    {
        public ControlTower_subscriber()
        {
            InitializeComponent();

            FlightCode.Text = "";
            SendToRunway.IsEnabled = false;
        }


        private void FlightCode_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (FlightCode.Text != "")
            {
                SendToRunway.IsEnabled = true;
            }
        }

        private void SendToRunway_Click(object sender, RoutedEventArgs e)
        {
            CreateNewFlight(FlightCode.Text);
            FlightCode.Text = "";
            SendToRunway.IsEnabled = false;
        }


        private void CreateNewFlight(string flightCode)
        {
            FlightWindow_publisher flight = new FlightWindow_publisher(flightCode);
            flight.Show();

            //subscribe
        }

    }
}