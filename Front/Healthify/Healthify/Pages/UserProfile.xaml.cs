using Healthify.Managers;
using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Healthify.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UserProfile : Page
    {
        private LoginInfo log;
        private DoctorInfo don;
        private string puid;
        public UserProfile()
        {
            InitializeComponent();
            log = new LoginInfo();
            don = new DoctorInfo();
            puid = null;
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
                var res = await UserCall.GetUserAsync(log.Username);
                nameblock.Text = res.Name;
                emailBlock.Text = res.Email;
                sexBlock.Text = res.Sex;
                dobBLock.Text = res.DOB;
                addressBlock.Text = res.Address;
                puid = res.UID;
            }

            catch (Exception) { }
        }

        #region Burger
        private void HamBut_Click(object sender, RoutedEventArgs e)
        {
            splitHam.IsPaneOpen = !splitHam.IsPaneOpen;
            if (!(log.TypeLogin.Equals("Doctor")))
                patInfoListItem.Visibility = Visibility.Collapsed;
                
        }

        private async void listHam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (medicalHistoryListItem.IsSelected) { Frame.Navigate(typeof(PatHistory), log); }
            else if (bloodListItem.IsSelected) { Frame.Navigate(typeof(Blood), log); }
            else if (suggestionsListItem.IsSelected) { Frame.Navigate(typeof(Suggestions), log); }
            else if (SponsorsListItem.IsSelected) { Frame.Navigate(typeof(Sponsors), log); }
            else if (feedListItem.IsSelected) { Frame.Navigate(typeof(Feedback), log); }
            else if (patInfoListItem.IsSelected)
            {
                don.DUID = log.Username;
                don.PUID = puid;
                don.DName = DocProfile.docName;                
                don.TypeLogin = log.TypeLogin;

                Frame.Navigate(typeof(PatientInfo), don);
            }
            else if (logoutListItem.IsSelected)
            {
                var title = "Pending changes";
                var content = "Are you sure that you wish to logout?";

                var yesCommand = new UICommand("Yes", null);
                var noCommand = new UICommand("No", null);
 
                var dialog = new MessageDialog(content, title);
                dialog.Options = MessageDialogOptions.None;
                dialog.Commands.Add(yesCommand);

                dialog.DefaultCommandIndex = 0;
                dialog.CancelCommandIndex = 0;

                if (noCommand != null)
                {
                    dialog.Commands.Add(noCommand);
                    dialog.CancelCommandIndex = (uint)dialog.Commands.Count - 1;
                }                

                var command = await dialog.ShowAsync();

                if (command == yesCommand)
                {
                    var keepTemp = Windows.Storage.ApplicationData.Current.LocalSettings;
                    keepTemp.Values["user"] = null;
                    keepTemp.Values["type"] = null;

                    Frame.Navigate(typeof(MainPage));
                }
                else
                {
                    ToastyToast.ShowToastNotification("Cancelled", "User cancelled logout");
                }                                
            }
        }
        #endregion
    }

    sealed class DoctorInfo
    {
        public string DUID { get; set; }
        public string DName { get; set; }        
        public string TypeLogin { get; set; }
        public string PUID { get; set; }
    }
}