using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Healthify
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        LoginInfo log;

        public MainPage()
        {
            this.InitializeComponent();
            log = new LoginInfo();
        }

        private void docbut_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Pages.LoginPage), "Doctor");
        }

        private void patbut_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Pages.LoginPage), "EndUser");
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;

            if ((localSettings.Values["user"] != null) && (localSettings.Values["type"] != null))
            {
                log.Username = (string)localSettings.Values["user"];
                log.TypeLogin = (string)localSettings.Values["type"];

                switch (log.TypeLogin)
                {
                    case "EndUser":
                        Frame.Navigate(typeof(Pages.UserProfile), log);
                        break;
                    case "Doctor":
                        Frame.Navigate(typeof(Pages.DocProfile), log);                        
                        break;
                }
            }
        }               
        
        private void patbut_PointerEntered(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            docbut.Visibility = Visibility.Collapsed;
            docRing.IsActive = true;
            docRing.Visibility = Visibility.Visible;
        }

        private void patbut_PointerExited(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            docRing.Visibility = Visibility.Collapsed;
            docRing.IsActive = false;
            docbut.Visibility = Visibility.Visible;
        }

        private void docbut_PointerEntered(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            patbut.Visibility = Visibility.Collapsed;
            patRing.IsActive = true;
            patRing.Visibility = Visibility.Visible;
        }

        private void docbut_PointerExited(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            patRing.Visibility = Visibility.Collapsed;
            patRing.IsActive = false;
            patbut.Visibility = Visibility.Visible;
        }
    }

    sealed class LoginInfo
    {
        public string Username { get; set; }       
        public string TypeLogin { get; set; }
    }
}
