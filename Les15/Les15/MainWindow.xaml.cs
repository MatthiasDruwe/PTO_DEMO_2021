using System;
using System.Collections.Generic;
using System.IO;
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

namespace Les15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            StreamWriter streamWriter = new StreamWriter("newFile.txt");

            try
            {
                streamWriter.WriteLine("Demo");
                
            }
            catch
            {
                // Los Probleem op.
                
            }
            finally
            {
                streamWriter.Close();
            }
        }
    }
}
