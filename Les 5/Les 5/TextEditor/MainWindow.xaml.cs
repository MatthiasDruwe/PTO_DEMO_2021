using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using Forms = System.Windows.Forms;


namespace TextEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string selectedPath;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void pathButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFolderBrowserDialog();
        }

        private void OpenFolderBrowserDialog()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = Environment.CurrentDirectory;
            DialogResult dialogResult = folderBrowserDialog.ShowDialog();

            if(dialogResult == Forms.DialogResult.OK)
            {
                selectedPath = folderBrowserDialog.SelectedPath;
                pathLabel.Content = selectedPath;
                LoadData();
            }
        }

        private void LoadData()
        {
            filesListBox.Items.Clear();
            // load data
            string[] files = Directory.GetFiles(selectedPath);

            foreach(string file in files)
            {
                if(file.EndsWith(".txt"))
                {
                    filesListBox.Items.Add(file);
                }
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void filesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
