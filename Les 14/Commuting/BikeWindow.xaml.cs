﻿using Commuting;
using Commuting.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for BikeWindow.xaml
    /// </summary>
    public partial class BikeWindow : Window
    {
        public BikeWindow()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            CreateTrainCommute();
        }

        private void CreateTrainCommute()
        {
            DateTime selectedDate = (DateTime)datePicker.SelectedDate;

            if (selectedDate != null)
            {
                Bike bike = new Bike(fromTextBox.Text, toTextBox.Text, selectedDate, Convert.ToDouble(distanceTextBox.Text));
                CommuteRepository commuteRepository = new CommuteRepository();
                commuteRepository.CreateCommute(bike);
                DialogResult = true;

            }

            Close();
        }
    }
}
