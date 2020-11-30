using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Demo_canvas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int score = 0;
        double interval = 1000;
        DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();

            DrawBear(200, 120);
            SetupTimer();
            scoreLabel.Content = score;
        }

        private void SetupTimer()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(interval); // new TimeSpan(0, 0, 5);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            drawingCanvas.Children.Clear();
            Random random = new Random();
            int x = random.Next(Convert.ToInt32(drawingCanvas.ActualWidth));
            int y = random.Next(Convert.ToInt32(drawingCanvas.ActualHeight));
            DrawBear(x, y);
        }

        private void DrawBear(double x, double y)
        {
            // left ear
            DrawEar(x - 60, y - 60);
            // right ear
            DrawEar(x + 60, y - 60);
            // Face
            DrawFace(x, y);
            // Eye
            DrawEye(x - 30, y - 25);
            DrawEye(x + 30, y - 25);
            // Mouth
            DrawMouth(x, y + 10);
            // nose
            DrawNose(x, y);

        }

        private void DrawMouth(double x, double y)
        {
            AddCircle(x, y, 120, 80, Brushes.Beige);
        }

        private void DrawEye(double x, double y)
        {
            AddCircle(x, y, 20, 40, Brushes.White);
            AddCircle(x, y - 5, 7.5, 7.5, Brushes.Black);
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
            Canvas.SetLeft(circle, x - width / 2); // position based on center
            Canvas.SetTop(circle, y - height / 2); // position based on center
            drawingCanvas.Children.Add(circle);
            circle.MouseDown += Circle_MouseDown;
        }

        private void Circle_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            drawingCanvas.Children.Clear();
            score++;
            scoreLabel.Content = score;

            if (score % 5 == 0)
            {
                interval = interval * 0.9;
                timer.Interval = TimeSpan.FromMilliseconds(interval);
            }
        }
    }
}
