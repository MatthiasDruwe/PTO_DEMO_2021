using System;
using System.Collections.Generic;
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

namespace Demo_canvas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DrawBear(200, 120);
            DrawBear(400, 120);
        }


        private void DrawBear(double x, double y)
        {
            // left ear
            DrawEar(x-60, y-60);
            // right ear
            DrawEar(x+60, y-60);
            // Face
            DrawFace(x, y);
            // Eye
            DrawEye(x-30, y-25);
            DrawEye(x+30, y-25);
            // Mouth
            DrawMouth(x,y+10);
            // nose
            DrawNose(x,y);

        }

        private void DrawMouth(double x, double y)
        {
            AddCircle(x, y, 120, 80, Brushes.Beige);
        }

        private void DrawEye(double x, double y)
        {
            AddCircle(x, y, 20, 40, Brushes.White);
            AddCircle(x, y-5, 7.5, 7.5, Brushes.Black);
        }

        private void DrawFace(double x, double y)
        {
            AddCircle(x, y, 200, 160, Brushes.SaddleBrown);
        }

        private void DrawNose(double x, double y)
        {
            AddCircle(x, y, 20, 20, Brushes.Red);

        }

        private void DrawEar(double x, double y)
        {
            AddCircle(x, y, 80, 80, Brushes.SaddleBrown);
            AddCircle(x, y, 40, 40, Brushes.Beige);
        }

        private void AddCircle(double x, double y, double width, double height, Brush color)
        {
            Ellipse circle = new Ellipse();
            circle.Height = height;
            circle.Width = width;
            circle.Fill = color;
            circle.Stroke = Brushes.Black;
            circle.StrokeThickness = 2.0;
            Canvas.SetLeft(circle, x - width/2); // position based on center
            Canvas.SetTop(circle, y - height/2); // position based on center
            drawingCanvas.Children.Add(circle);
        }
    }
}
