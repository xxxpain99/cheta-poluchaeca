using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Xml.Linq;

namespace WpfApp7
{
    enum CreateState
    {
        None, First, Second,
    }

    public class BrushColor
    {
        public SolidColorBrush Color { get; set; }
        public string Name { get; set; }
    }
    public partial class MainWindow : Window
    {
        private SolidColorBrush defaultBrush = new SolidColorBrush(Colors.LightPink);
        private SolidColorBrush defaultFill = new SolidColorBrush(Color.FromArgb(70, 0, 0, 0));
        private double defaultThikness = 2;
        private Point lastPoint;
        private Shape lastShape = null;
        private CreateState state = CreateState.None;
        public ObservableCollection<BrushColor> BrushColors { get; set; }
            = new ObservableCollection<BrushColor>()
            {
                    new BrushColor() { Color = Brushes.Red, Name = "Красный" },
                    new BrushColor() { Color = Brushes.Black, Name = "Черный" },
                    new BrushColor() { Color = Brushes.Blue, Name = "Голубой" },
                    new BrushColor() { Color = Brushes.Yellow, Name = "Желтый" },
                    new BrushColor() { Color = Brushes.Green, Name = "Зеленый" },
                    new BrushColor() { Color = Brushes.Orange, Name = "Оранжевый" },
                    new BrushColor() { Color = Brushes.Gray, Name = "Серый" },
                    new BrushColor() { Color = Brushes.Pink, Name = "Розовый" },
            };


        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }
        private void AppCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (lastShape == null) return;
            Point currentPoint = e.GetPosition(AppCanvas);
            if (state == CreateState.First)
            {
                Canvas.SetLeft(lastShape, currentPoint.X);
                Canvas.SetLeft(lastShape, currentPoint.Y);
                lastPoint = currentPoint;
                return;
            }
            if (lastShape == null) return;
            lastShape.Width = Math.Abs(currentPoint.X - lastPoint.X);
            lastShape.Width = Math.Abs(currentPoint.Y - lastPoint.Y);



        }

        private void CreateDeafultRectangle()
        {


        }

        private void Rectangle_Click(object sender, RoutedEventArgs e)
        {
            CreateDeafultRectangle();
            state = CreateState.First;
        }

        private void Elipse_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Line_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AppCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}

