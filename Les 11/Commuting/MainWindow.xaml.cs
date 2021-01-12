using Commuting.Model;
using System;
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
        }

        private void addCarButton_Click(object sender, RoutedEventArgs e)
        {
            CarWindow window = new CarWindow();
            CreateNewCommute(window);
        }

        private void addBikeButton_Click(object sender, RoutedEventArgs e)
        {
            BikeWindow window = new BikeWindow();
            CreateNewCommute(window);

        }

        private void addTrainButton_Click(object sender, RoutedEventArgs e)
        {
            TrainWindow window = new TrainWindow();
            CreateNewCommute(window);
            //if (window.ShowDialog() == true)
            //{
            //    commutingListBox.Items.Add(window.CurrentTrain);
            //}
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


        private void ShowTotalRefund()
        {
            double totalRefund = CalculateTotalRefund();
            totalRefundTextBox.Content = $"Total refund is: {totalRefund:€#.##}";
        }

        private double CalculateTotalRefund()
        {
            double refund = 0;

            foreach(Commute commute in commutingListBox.Items)
            {
                refund = refund + commute.CalculateRefund();
            }

            return refund;
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            // Create file
            // Loop over alle commutes
            // commute.ToCSVLine() opslaan in bestand.
        }

        private void loadButton_Click(object sender, RoutedEventArgs e)
        {
            // lijn per lijn van file overlopen 
            string line = "Car;to;from;date;distance"
            Commute.CreateCommuteFromCSVLine(line)
        }
    }
}
