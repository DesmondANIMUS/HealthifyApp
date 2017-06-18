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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Healthify.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Feedback : Page
    {
        LoginInfo log;

        public Feedback()
        {
            this.InitializeComponent();
            log = new LoginInfo();            
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            log = (LoginInfo)e.Parameter;
            if (log.TypeLogin.Equals("Doctor"))
            {
                medicalHistoryListItem.Visibility = Visibility.Collapsed;
                suggestionsListItem.Visibility = Visibility.Collapsed;
            }
        }

        private void HamBut_Click(object sender, RoutedEventArgs e)
        {
            splitHam.IsPaneOpen = !splitHam.IsPaneOpen;
        }

        private void listHam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (medicalHistoryListItem.IsSelected) { Frame.Navigate(typeof(PatHistory), log); }
            else if (bloodListItem.IsSelected) { Frame.Navigate(typeof(Blood), log); }
            else if (suggestionsListItem.IsSelected) { Frame.Navigate(typeof(Suggestions), log); }
            else if (SponsorsListItem.IsSelected) { Frame.Navigate(typeof(Sponsors), log); }
            else if (homeListItem.IsSelected)
            {
                if (log.TypeLogin.Equals("Doctor"))
                    Frame.Navigate(typeof(DocProfile), log);
                else
                    Frame.Navigate(typeof(UserProfile), log);
            }
        }
    }
}
