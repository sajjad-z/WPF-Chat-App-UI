using System.Windows;
using System.Windows.Controls;

namespace Chat_App.UserControls
{
    public partial class Chat_Seprator : UserControl
    {
        public Chat_Seprator()
        {
            InitializeComponent();
        }


        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(Chat_Seprator));


    }
}