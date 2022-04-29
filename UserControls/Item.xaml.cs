using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Chat_App.UserControls
{
    public partial class Item : UserControl
    {
        public Item()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(Item));


        public string Message
        {
            get { return (string)GetValue(MessageProperty); }
            set { SetValue(MessageProperty, value); }
        }

        public static readonly DependencyProperty MessageProperty = DependencyProperty.Register("Message", typeof(string), typeof(Item));


        public string TagName
        {
            get { return (string)GetValue(TagNameProperty); }
            set { SetValue(TagNameProperty, value); }
        }

        public static readonly DependencyProperty TagNameProperty = DependencyProperty.Register("TagName", typeof(string), typeof(Item));


        public string MessageCount
        {
            get { return (string)GetValue(MessageCountProperty); }
            set { SetValue(MessageCountProperty, value); }
        }

        public static readonly DependencyProperty MessageCountProperty = DependencyProperty.Register("MessageCount", typeof(string), typeof(Item));


        public bool IsActive
        {
            get { return (bool)GetValue(IsActiveProperty); }
            set { SetValue(IsActiveProperty, value); }
        }

        public static readonly DependencyProperty IsActiveProperty = DependencyProperty.Register("IsActive", typeof(bool), typeof(Item));


        public Brush Color
        {
            get { return (Brush)GetValue(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }

        public static readonly DependencyProperty ColorProperty = DependencyProperty.Register("Color", typeof(Brush), typeof(Item));


        public Visibility Visible
        {
            get { return (Visibility)GetValue(VisibleProperty); }
            set { SetValue(VisibleProperty, value); }
        }

        public static readonly DependencyProperty VisibleProperty = DependencyProperty.Register("Visible", typeof(Visibility), typeof(Item));


        public ImageSource Image
        {
            get { return (ImageSource)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        public static readonly DependencyProperty ImageProperty = DependencyProperty.Register("Image", typeof(ImageSource), typeof(Item));


    }
}