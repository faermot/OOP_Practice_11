using System.Windows;
using System.Windows.Media;
using FontAwesome.WPF;

namespace OOP_Practice_11.View.UserControls
{
    public partial class InfoCardUserControl : System.Windows.Controls.UserControl
    {
        public InfoCardUserControl()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(nameof(Title), typeof(string), typeof(InfoCardUserControl));

        public string Number
        {
            get { return (string)GetValue(NumberProperty); }
            set { SetValue(NumberProperty, value); }
        }
        public static readonly DependencyProperty NumberProperty =
            DependencyProperty.Register(nameof(Number), typeof(string), typeof(InfoCardUserControl));

        public FontAwesomeIcon Icon
        {
            get { return (FontAwesomeIcon)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register(nameof(Icon), typeof(FontAwesomeIcon), typeof(InfoCardUserControl));

        public Color BorderBackground1
        {
            get { return (Color)GetValue(BorderBackground1Property); }
            set { SetValue(BorderBackground1Property, value); }
        }
        public static readonly DependencyProperty BorderBackground1Property =
            DependencyProperty.Register(nameof(BorderBackground1), typeof(Color), typeof(InfoCardUserControl));

        public Color BorderBackground2
        {
            get { return (Color)GetValue(BorderBackground2Property); }
            set { SetValue(BorderBackground2Property, value); }
        }
        public static readonly DependencyProperty BorderBackground2Property =
            DependencyProperty.Register(nameof(BorderBackground2), typeof(Color), typeof(InfoCardUserControl));

        public Color EllipseBackground1
        {
            get { return (Color)GetValue(EllipseBackground1Property); }
            set { SetValue(EllipseBackground1Property, value); }
        }
        public static readonly DependencyProperty EllipseBackground1Property =
            DependencyProperty.Register(nameof(EllipseBackground1), typeof(Color), typeof(InfoCardUserControl));

        public Color EllipseBackground2
        {
            get { return (Color)GetValue(EllipseBackground2Property); }
            set { SetValue(EllipseBackground2Property, value); }
        }
        public static readonly DependencyProperty EllipseBackground2Property =
            DependencyProperty.Register(nameof(EllipseBackground2), typeof(Color), typeof(InfoCardUserControl));
    }
}
