using BMI.Model;
using BMI.Repository;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace BMI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserRepository userRepository = new UserRepository();
        BmiRepository bmiRepository = new BmiRepository();

        public MainWindow()
        {
            InitializeComponent();
            periodComboBox.ItemsSource = Enum.GetValues(typeof(TimePeriod));
            periodComboBox.SelectedItem = TimePeriod.All;

            bmiGroupBox.Visibility = Visibility.Hidden;
            LoadUsers();
        }


        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user.BirthDate = (DateTime)birtDatePicker.SelectedDate;
            user.Name = nameTextBox.Text;

            userRepository.Create(user);
            LoadUsers();
        }

        private void LoadUsers()
        {
            userListBox.ItemsSource = userRepository.GetAllUsers();
        }

        private void saveBMIButton_Click(object sender, RoutedEventArgs e)
        {
            Bmi bmi = new Bmi();

            bmi.Date = (DateTime)bmiDatePicker.SelectedDate;
            bmi.Weight = Convert.ToDouble(weightTextBox.Text);
            bmi.Height = Convert.ToDouble(heightTextBox.Text);
            User selectedUser = (User)userListBox.SelectedItem;
            bmi.User = selectedUser;

            bmiRepository.CreateBmi(bmi);
            LoadBmiDataForUser(selectedUser);
        }

        private void userListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (userListBox.SelectedItem != null)
            {
                User user = (User)userListBox.SelectedItem;
                bmiGroupBox.Visibility = Visibility.Visible;
                bmiGroupBox.Header = user.Name;
                LoadBmiDataForUser(user);

            }
            else
            {
                bmiGroupBox.Visibility = Visibility.Hidden;
            }
        }

        private void LoadBmiDataForUser(User user)
        {
            List<Bmi> bmidata = bmiRepository.GetAllBmiFor(user);
            entryListBox.ItemsSource = bmidata;
        }

        private void periodComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (userListBox.SelectedItem != null && periodComboBox.SelectedIndex != null)
            {
                maxBmiLabel.Content = bmiRepository.GetMaxBmiFor((User)userListBox.SelectedItem, (TimePeriod)periodComboBox.SelectedItem);
            }
        }

    }
}
