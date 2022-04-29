using System.Windows;
using System.Windows.Controls;

namespace Chat_App.UserControls
{
    public partial class MyMessageChat : UserControl
    {
        public MyMessageChat()
        {
            InitializeComponent();
        }

        public string Message
        {
            get { return (string)GetValue(MessageProperty); }
            set { SetValue(MessageProperty, value); }
        }

        public static readonly DependencyProperty MessageProperty = DependencyProperty.Register("Message", typeof(string), typeof(MyMessageChat));

    }
}