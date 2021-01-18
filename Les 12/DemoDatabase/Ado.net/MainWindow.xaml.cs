using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;

namespace Ado.net
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private List<string> SearchUser(string name)
        {
            List<string> names = new List<string>();
            SqlConnection connection =
                new SqlConnection("data source=(localdb)\\MSSQLLOCALDB;initial catalog=Messages;");

            SqlCommand command = new SqlCommand($"SELECT first_name, last_name FROM dbo.authors WHERE first_name = '{name}';", connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                names.Add($"{reader[0]} {reader[1]}");
            }
            reader.Close();
            connection.Close();


            return names;
        }

        private void UpdateUser(string name, string newName)
        {
            SqlConnection connection =
                new SqlConnection("data source=(localdb)\\MSSQLLOCALDB;initial catalog=Messages;");

            SqlCommand command = new SqlCommand($"UPDATE  dbo.authors SET first_name = '{newName}' WHERE first_name = '{name}';", connection);
            
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();


        }


        private void SearchButton_OnClick(object sender, RoutedEventArgs e)
        {
            nameListBox.ItemsSource = SearchUser(nameTextBox.Text);
        }

        

        private void FillSqlInjectionButtom_OnClick(object sender, RoutedEventArgs e)
        {
            editNameTextBox.Text = nameTextBox.Text + "'; drop table dbo.posts;drop table dbo.authors;--";
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateUser(nameTextBox.Text, editNameTextBox.Text);
        }

        private void GetTableNamesButton_Click(object sender, RoutedEventArgs e)
        {
            nameTextBox.Text = "1' AND 1=2 UNION SELECT table_schema, table_name FROM information_schema.tables;--";


        }
    }
}
