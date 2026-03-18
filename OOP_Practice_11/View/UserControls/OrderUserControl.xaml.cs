using System.Windows;
using FontAwesome.WPF;

namespace OOP_Practice_11.View.UserControls
{
    public partial class OrderUserControl : System.Windows.Controls.UserControl
    {
        public OrderUserControl()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(nameof(Title), typeof(string), typeof(OrderUserControl));

        public string Desc
        {
            get { return (string)GetValue(DescProperty); }
            set { SetValue(DescProperty, value); }
        }
        public static readonly DependencyProperty DescProperty =
            DependencyProperty.Register(nameof(Desc), typeof(string), typeof(OrderUserControl));

        public FontAwesomeIcon Icon
        {
            get { return (FontAwesomeIcon)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register(nameof(Icon), typeof(FontAwesomeIcon), typeof(OrderUserControl));
    }
}
