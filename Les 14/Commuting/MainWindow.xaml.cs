using Commuting;
using Commuting.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;

namespace WpfApp4
{
    
    // * 3 types vervoer toevoegen => Hebben een gemeenschappelijke basis 
    // * Gemeenschappelijke basis => Vertrek, bestemming, datum
    // * Specifieke types
    //      * Car => afstand
    //      * Bike => afstand
    //      * Train => ticketprijs


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
 
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void addCarButton_Click(object sender, RoutedEventArgs e)
        {
            CarWindow window = new CarWindow();
            window.ShowDialog();
            LoadData();
        }

        private void addBikeButton_Click(object sender, RoutedEventArgs e)
        {
            BikeWindow window = new BikeWindow();
            window.ShowDialog();
            LoadData();
        }

        private void addTrainButton_Click(object sender, RoutedEventArgs e)
        {
            TrainWindow window = new TrainWindow();
            window.ShowDialog();
            LoadData();
        }

        private void CreateNewCommute(Window window)
        {

            if (window.ShowDialog() == true)
            {
                Commute commute = (Commute)window.Content;
                #region comment
                //switch (window)
                //{
                //    case CarWindow cw:
                //        commute = cw.CurrentCar;
                //        break;
                //    case BikeWindow bw:
                //        commute = bw.CurrentBike;
                //        break;
                //    case TrainWindow tw:
                //        commute = tw.CurrentTrain;
                //        break;
                //}

                // Onderstaande code is zelfde als bovenstaande switch
                //
                //if(window is CarWindow)
                //{
                //    CarWindow cw = (CarWindow)window;
                //    commute = cw.CurrentCar;
                //} else if( window is  BikeWindow)
                //{
                //    BikeWindow bw = (BikeWindow)window;
                //    commute = bw.CurrentBike;
                //}
                //else if (window is TrainWindow)
                //{
                //    TrainWindow tw = (TrainWindow)window;
                //    commute = tw.CurrentTrain;
                //}
                #endregion

                if (commute != null)
                {
                    commutingListBox.Items.Add(commute);
                    ShowTotalRefund();
                }
            }
        }

        private void LoadData()
        {
            CommuteRepository repository = new CommuteRepository();
            commutingListBox.ItemsSource = repository.GetAllCommutes();
            ShowTotalRefund();
        }

        private void ShowTotalRefund()
        {
            double totalRefund = CalculateTotalRefund();
            totalRefundTextBox.Content = $"Total refund is: {totalRefund:€#.##}";
        }

        private double CalculateTotalRefund()
        {
           
            return commutingListBox.Items.OfType<Commute>().Sum(GetRefund);
        }

        private double GetRefund(Commute commute)
        {
            return commute.CalculateRefund();
        }

    }
}
