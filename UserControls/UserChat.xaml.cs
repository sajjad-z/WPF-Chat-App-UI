using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Chat_App.UserControls
{
    public partial class UserChat : UserControl
    {
        public UserChat()
        {
            InitializeComponent();
        }


        public string Username
        {
            get { return (string)GetValue(UsernameProperty); }
            set { SetValue(UsernameProperty, value); }
        }

        public static readonly DependencyProperty UsernameProperty = DependencyProperty.Register("Username", typeof(string), typeof(UserChat));
        
        
        public ImageSource Source
        {
            get { return (ImageSource)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        public static readonly DependencyProperty SourceProperty = DependencyProperty.Register("Source", typeof(ImageSource), typeof(UserChat));


    }
}