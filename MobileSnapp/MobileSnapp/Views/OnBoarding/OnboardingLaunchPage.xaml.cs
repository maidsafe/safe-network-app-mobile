using MobileSnapp.ViewModels.Onboarding;
using Xamarin.Forms;

namespace MobileSnapp.Views.Onboarding
{
    public partial class OnboardingLaunchPage : ContentPage
    {
        private OnBoardingLaunchViewModel _viewModel;

        public OnboardingLaunchPage()
        {
            InitializeComponent();
        }

        private void OpenLoginPage(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Onboading.LoginPage());
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (_viewModel == null)
            {
                _viewModel = new OnBoardingLaunchViewModel();
                BindingContext = _viewModel;
            }
        }
    }
}
