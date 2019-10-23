using Xamarin.Forms;

namespace MobileSnapp.Views.Onboarding
{
    public partial class OnboardingLaunchPage : ContentPage
    {
        public OnboardingLaunchPage()
        {
            InitializeComponent();
        }

        private void OpenLoginPage(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Onboading.LoginPage());
        }
    }
}
