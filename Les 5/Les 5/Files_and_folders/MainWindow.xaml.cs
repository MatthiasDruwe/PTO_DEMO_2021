using System;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using Forms = System.Windows.Forms;

namespace Files_and_folders
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DemoDirectories();
        }

        private void DemoDirectories()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] files = Directory.GetFiles(path);
            string[] directories = Directory.GetDirectories(path);
            Directory.CreateDirectory(Path.Combine(path, "demo les 5"));
            var x = files.Length;
        }

        private void DemoFiles()
        {

        }

        private void DemoOpenFileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "textbestanden (*.txt)|*.txt|Alle bestanden|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.FileName = "demo.txt";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string personalPath = Path.Combine(path, "personal");
            openFileDialog.InitialDirectory = personalPath ;

            DialogResult result = openFileDialog.ShowDialog();
         
            if(result == Forms.DialogResult.OK)
            {
                demoLabel.Content = openFileDialog.FileName;
            } 
        }

        private void DemoSaveFileDialog()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            DialogResult result = saveFileDialog.ShowDialog();

            if (result == Forms.DialogResult.OK)
            {
                demoLabel.Content = saveFileDialog.FileName;
            }
        }


        private void DemoFolderBrowserDialog()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == Forms.DialogResult.OK)
            {
                demoLabel.Content = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
