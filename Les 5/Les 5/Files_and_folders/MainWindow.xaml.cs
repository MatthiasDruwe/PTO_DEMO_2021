using System;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using Forms = System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

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
            DemoFile();
        }

        private void DemoDirectories()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] files = Directory.GetFiles(path);
            string[] directories = Directory.GetDirectories(path);
            Directory.CreateDirectory(Path.Combine(path, "demo les 5"));
            var x = files.Length;
        }

        private void DemoStreamWriter()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "demoles5.txt");

            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.WriteLine("Hello World2!");
            streamWriter.WriteLine("Dag Wereld2!");
            streamWriter.Close();
        }

        private void DemoStreamReader()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "demoles5.txt");

            // open streamreader
            StreamReader streamReader = new StreamReader(path);
            

            // bestand lijn per lijn inlezen
            string line = streamReader.ReadLine();
            while (line != null) 
            {
                MessageBox.Show(line);
                line = streamReader.ReadLine();
            } 

            // sluit streamreader
            streamReader.Close();

        }

        private void DemoFile()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "demoles5.txt");
            MessageBox.Show(File.ReadAllText(path));
            File.WriteAllText(path, "new text");
            StreamWriter streamWriter = File.CreateText(path);
            streamWriter.WriteLine("Hello World2!");
            streamWriter.WriteLine("Dag Wereld2!");
            streamWriter.Close();

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
