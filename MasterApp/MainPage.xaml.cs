using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MasterApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    
     public class MyWebViewExtention
     {
       
        public static readonly DependencyProperty HtmlSourceProperty =
           DependencyProperty.RegisterAttached("HtmlSource", typeof(string), typeof(MyWebViewExtention), new PropertyMetadata("", OnHtmlSourceChanged));

        public static string GetHtmlSource(DependencyObject obj) { return (string)obj.GetValue(HtmlSourceProperty); }
        public static void SetHtmlSource(DependencyObject obj, string value) { obj.SetValue(HtmlSourceProperty, value); }
        private static void OnHtmlSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            WebView webView = d as WebView;
            if (webView != null)
            {
                webView.NavigateToString((string)e.NewValue);
            }
        }
     }

    public class Email {
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }

    public sealed partial class MainPage : Page
    {
        public string htmlText = "<html>some html</html>";
        public List<Email> Emails;
        public MainPage()
        {
            this.InitializeComponent();
            this.DataContext = this;
            Emails = new List<Email>
            {
                new Email
                {
                    From = "Steve Johnson",
                    Subject = "Lunch Tomorrow",
                    Body = "Are you available for lunch tomorrow? A client would like to discuss a project with you.",
                    
                },
                new Email
                {
                    From = "Pete Davidson",
                    Subject = "Kids game",
                    Body = "Don't forget the kids have their soccer game this Friday. We have to supply end of game snacks.",
                    
                },
                new Email
                {
                    From = "OneDrive",
                    Subject = "Check out your event recap",
                    Body = "Your new album.\r\nYou uploaded some photos to yuor OneDrive and automatically created an album for you.",
                    
                },
                new Email
                {
                    From = "Twitter",
                    Subject = "Follow randomPerson, APersonYouMightKnow",
                    Body = "Here are some people we think you might like to follow:\r\n.@randomPerson\r\nAPersonYouMightKnow",
                    
                },
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //webView.NavigateToString("<html>some html</html>");
            //webView.Source = new Uri("https://www.google.com");
        }
    }
}
