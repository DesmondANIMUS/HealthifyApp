using Healthify.Managers;
using System;
using Windows.Foundation;
using Windows.Media.Capture;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Healthify.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        LoginInfo log;         
        public LoginPage()
        {
            this.InitializeComponent();
            log = new LoginInfo();    
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            log.TypeLogin = e.Parameter.ToString();
        }

        private async void useTheQR_Click(object sender, RoutedEventArgs e)
        {
            CameraCaptureUI captureUI = new CameraCaptureUI();
            captureUI.PhotoSettings.Format = CameraCaptureUIPhotoFormat.Jpeg;
            captureUI.PhotoSettings.CroppedSizeInPixels = new Size(200, 200);

            StorageFile photo = await captureUI.CaptureFileAsync(CameraCaptureUIMode.Photo);

            if (photo == null)
            {
                // User cancelled photo capture
                return;
            }
        }

        private void useTheUID_Click(object sender, RoutedEventArgs e)
        {            
            useTheQR.Visibility = Visibility.Collapsed;
            useTheUID.Visibility = Visibility.Collapsed;

            usernameBox.Visibility = Visibility.Visible;
            sendUserName.Visibility = Visibility.Visible;            
        }        

        private async void sendUserName_Click(object sender, RoutedEventArgs e)
        {
            log.Username = usernameBox.Text;

            try
            {
                ringOring.IsActive = true;
                ringOring.Visibility = Visibility.Visible;
                sendUserName.Visibility = Visibility.Collapsed;

                var res = await LoginVerifyCall.LoginVerifyAsync(log, null);
                if (res.response.Equals("Success"))
                {
                    ToastyToast.ShowToastNotification("Success", "Yay!!!");
                    usernameBox.Visibility = Visibility.Collapsed;

                    ringOring.Visibility = Visibility.Collapsed;
                    ringOring.IsActive = false;

                    otpBox.Visibility = Visibility.Visible;
                    sendOtp.Visibility = Visibility.Visible;
                }
                else
                {
                    ToastyToast.ShowToastNotification("No", "noooooooooo!!!");
                    ringOring.Visibility = Visibility.Collapsed;
                    ringOring.IsActive = false;
                    sendUserName.Visibility = Visibility.Visible;
                }
            }

            catch (Exception) { }
        }

        private async void sendOtp_Click(object sender, RoutedEventArgs e)
        {
            string otp = otpBox.Text;            
            ringOring.IsActive = true;
            ringOring.Visibility = Visibility.Visible;
            sendOtp.Visibility = Visibility.Collapsed;
            try
            {
                var res = await LoginVerifyCall.LoginVerifyAsync(null, otp);
                if (res.response.Equals("Success"))
                {
                    var keepTemp = ApplicationData.Current.LocalSettings;
                    keepTemp.Values["user"] = log.Username;
                    keepTemp.Values["type"] = log.TypeLogin;

                    if (log.TypeLogin.Equals("Doctor"))
                        Frame.Navigate(typeof(DocProfile), log);
                    else
                        Frame.Navigate(typeof(UserProfile), log);
                }
                else
                {
                    ToastyToast.ShowToastNotification("No", "Wrong OTP :(");
                    ringOring.Visibility = Visibility.Collapsed;
                    ringOring.IsActive = false;
                    sendOtp.Visibility = Visibility.Visible;
                }
            }
            catch (Exception) { }
        }
    }
}
