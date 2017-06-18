using Healthify.Managers;
using Healthify.Models;
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

namespace Healthify.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PatHistory : Page
    {
        LoginInfo log;
        ObservableCollection<hissResponse> history;
        public PatHistory()
        {
            this.InitializeComponent();
            log = new LoginInfo();
            history = new ObservableCollection<hissResponse>();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            log = (LoginInfo)e.Parameter;
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                await HistoricalCall.GettingActual(history, log.Username);
            }
            catch (Exception) { }
        }

        private void HamBut_Click(object sender, RoutedEventArgs e)
        {
            splitHam.IsPaneOpen = !splitHam.IsPaneOpen;
        }

        private void listHam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (homeListItem.IsSelected)
            {
                if (log.TypeLogin.Equals("Doctor"))
                    Frame.Navigate(typeof(DocProfile), log);
                else
                    Frame.Navigate(typeof(UserProfile), log);
            }
            else if (bloodListItem.IsSelected) { Frame.Navigate(typeof(Blood), log); }
            else if (suggestionsListItem.IsSelected) { Frame.Navigate(typeof(Suggestions), log); }
            else if (SponsorsListItem.IsSelected) { Frame.Navigate(typeof(Sponsors), log); }
            else if (feedListItem.IsSelected) { Frame.Navigate(typeof(Feedback), log); }
        }
    }
}
