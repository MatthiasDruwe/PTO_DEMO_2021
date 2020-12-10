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

namespace Recap
{
    /// <summary>
    /// Interaction logic for WindowTwo.xaml
    /// </summary>
    public partial class WindowTwo : Window
    {
        public WindowTwo(string message)
        {
            InitializeComponent();
            messageLabel.Content = message;
        }
    }
}
