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
    public sealed partial class DocProfile : Page
    {
        private LoginInfo log;
        internal static string docName;
        public DocProfile()
        {
            this.InitializeComponent();
            log = new LoginInfo();
            docName = null;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            log = (LoginInfo)e.Parameter;
        }

        private void submission_Click(object sender, RoutedEventArgs e)
        {            
            log.Username = usenamebox.Text;            

            Frame.Navigate(typeof(UserProfile), log);
        }

        private void HamBut_Click(object sender, RoutedEventArgs e)
        {
            splitHam.IsPaneOpen = !splitHam.IsPaneOpen;
        }

        private async void listHam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {            
            if (bloodListItem.IsSelected) { Frame.Navigate(typeof(Blood), log); }         
            else if (SponsorsListItem.IsSelected) { Frame.Navigate(typeof(Sponsors), log); }
            else if (feedListItem.IsSelected) { Frame.Navigate(typeof(Feedback), log); }            
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
                    ToastyToast.ShowToastNotification("Cancelled", "User cancelled logout");
            }
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                var doctorInfo = await DoctorCall.GetDoctorAsync(log.Username);
                docName = doctorInfo.Name;
                docNameBlock.Text = doctorInfo.Name;
                docEmail.Text = doctorInfo.Email;
                docAddress.Text = doctorInfo.Address;
                docSex.Text = doctorInfo.Sex;
            }

            catch (Exception) { }
        }
    }
}
