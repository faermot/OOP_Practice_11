using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Wpf;

namespace OOP_Practice_11
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitChart();
        }

        private void InitChart()
        {
            var fillBrush = new LinearGradientBrush
            {
                StartPoint = new System.Windows.Point(0.5, 0),
                EndPoint = new System.Windows.Point(0.5, 1),
                GradientStops = new GradientStopCollection
                {
                    new GradientStop((Color)ColorConverter.ConvertFromString("#B397E2"), 0.0),
                    new GradientStop((Color)ColorConverter.ConvertFromString("#2E1F7A"), 1.2)
                }
            };

            var strokeBrush = new SolidColorBrush(
                (Color)ColorConverter.ConvertFromString("#ADA4FD"));

            profitChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Stroke = strokeBrush,
                    StrokeThickness = 2,
                    PointGeometrySize = 0,
                    Fill = fillBrush,
                    Values = new ChartValues<double>
                    {
                        20000, 17000, 30000, 15000, 50000,
                        30000, 20000, 35000, 45000, 25000,
                        40000, 55000
                    }
                }
            };
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
