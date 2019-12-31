using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MasterApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        public ObservableCollection<Email> Emails { get; set; }
        public BlankPage1()
        {
            this.InitializeComponent();

            Emails = new ObservableCollection<Email>();
            Emails.Add(new Email
            {
                From = "Steve Johnson",
                Subject = "Lunch Tomorrow",
                Body = "Are you available for lunch tomorrow? A client would like to discuss a project with you.",

            });
            Emails.Add(new Email
            {
                From = "Steve Johnson",
                Subject = "Lunch Tomorrow",
                Body = "Are you available for lunch tomorrow? A client would like to discuss a project with you.",

            });
            Emails.Add(new Email
            {
                From = "Pete Davidson",
                Subject = "Kids game",
                Body = "Don't forget the kids have their soccer game this Friday. We have to supply end of game snacks.",

            });
            Emails.Add(new Email
            {
                From = "OneDrive",
                Subject = "Check out your event recap",
                Body = "Your new album.\r\nYou uploaded some photos to yuor OneDrive and automatically created an album for you.",

            });

           
        }
    }
}
