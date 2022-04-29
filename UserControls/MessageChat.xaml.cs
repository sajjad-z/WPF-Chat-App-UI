using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Chat_App.UserControls
{

    public partial class MessageChat : UserControl
    {
        public MessageChat()
        {
            InitializeComponent();
        }


        public string Message
        {
            get { return (string)GetValue(MessageProperty); }
            set { SetValue(MessageProperty, value); }
        }

        public static readonly DependencyProperty MessageProperty = DependencyProperty.Register("Message", typeof(string), typeof(MessageChat));
        
        
        public Brush Color
        {
            get { return (Brush)GetValue(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }

        public static readonly DependencyProperty ColorProperty = DependencyProperty.Register("Color", typeof(Brush), typeof(MessageChat));

    }
}