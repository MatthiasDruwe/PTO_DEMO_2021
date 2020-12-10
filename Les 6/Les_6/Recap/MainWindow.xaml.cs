using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using Forms = System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace Recap
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

        private void OpenFileDialogButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "muziek bestanden|*.mp3; *.wav; *.m4a|alle bestanden|*.*";
            openFileDialog.Title = "Kies je muziekbestand";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            Forms.DialogResult result =  openFileDialog.ShowDialog();

            if(result ==  Forms.DialogResult.OK)
            {
                MessageBox.Show(openFileDialog.FileName);
            } else if(result == Forms.DialogResult.Cancel)
            {
                MessageBox.Show("Geen selectie");
            }
        }

        private void SaveFileDialogButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
        }

        private void FolderBrowserDialogButton_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "Personal"
                );
            Forms.DialogResult result = folderBrowserDialog.ShowDialog();


            if(result == Forms.DialogResult.OK)
            {
                string path = folderBrowserDialog.SelectedPath;
                string[] files = Directory.GetFiles(path);
                foreach (string s in files)
                {
                    Debug.WriteLine(Path.GetFileName(s));
                }
            }

        }

        private void OpenNewWindowButton_Click(object sender, RoutedEventArgs e)
        {
            WindowTwo windowTwo = new WindowTwo("Hello World");
            windowTwo.Show();
        }
    }
}
