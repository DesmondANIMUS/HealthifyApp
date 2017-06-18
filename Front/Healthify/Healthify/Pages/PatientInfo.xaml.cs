using Healthify.Managers;
using Healthify.Models;
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
    public sealed partial class PatientInfo : Page
    {
        private DoctorInfo don;
        LoginInfo log;
        private HitoryInfo diseaseData;
        public PatientInfo()
        {
            this.InitializeComponent();
            don = new DoctorInfo();
            diseaseData = new HitoryInfo();
            log = new LoginInfo();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);            

            don = (DoctorInfo)e.Parameter;                        
        }

        private async void sendDatatoDB_Click(object sender, RoutedEventArgs e)
        {
            diseaseData.DUID = DataSecurity.EncryptThisData(don.DUID, Constants.PRIVPASS);
            diseaseData.DName = DataSecurity.EncryptThisData(don.DName, Constants.PRIVPASS);
            diseaseData.PUID = don.PUID;
            diseaseData.Disease = DataSecurity.EncryptThisData(disName.Text, Constants.PRIVPASS);
            diseaseData.Medicine = DataSecurity.EncryptThisData(medicBox.Text, Constants.PRIVPASS);
            diseaseData.Date = DataSecurity.EncryptThisData(dateOdater.Date.ToString(), Constants.PRIVPASS);
            string duration = dateFromPicker.Date.ToString() + " - " + dateToPicker.Date.ToString();
            diseaseData.Duration = DataSecurity.EncryptThisData(duration, Constants.PRIVPASS);
            
            var res = await UpdateHistoryCall.UpdatPatientHistoryAsync(diseaseData);

            log.TypeLogin = don.TypeLogin;
            log.Username = don.DUID;
            if (res.response.Equals("Success"))
                Frame.Navigate(typeof(UserProfile), log);
            else
            {
                ToastyToast.ShowToastNotification("Trouble :/", "Something went wrong :/");
                disName.Text = ""; medicBox.Text = "";
            }            
        }
    }

    sealed class HitoryInfo
    {
        public string DName { get; set; }
        public string PUID { get; set; }
        public string DUID { get; set; }
        public string Disease { get; set; }
        public string Date { get; set; }
        public string Duration { get; set; }
        public string Medicine { get; set; }
    }
}
