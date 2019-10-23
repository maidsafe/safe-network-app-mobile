using System.Collections.ObjectModel;
using MobileSnapp.Helpers;
using MobileSnapp.Models.Onboarding;
using MvvmHelpers;

namespace MobileSnapp.ViewModels.Onboarding
{
    public class CreateAccountOnboardingViewModel : BaseViewModel
    {
        private const string _staticContentFile = "CreateAccountOnboarding.json";

        private ObservableCollection<CreateAccountOnboardingItem> _onBordingOptions;

        public ObservableCollection<CreateAccountOnboardingItem> OnBordingOptions
        {
            get { return _onBordingOptions; }
            set { _onBordingOptions = value; }
        }

        public CreateAccountOnboardingViewModel()
        {
            OnBordingOptions = new ObservableCollection<CreateAccountOnboardingItem>(
                ContentHelpers.PopulateData<CreateAccountOnboardingStaticContent>(
                    _staticContentFile)
                .CreateAccountOnboarding);
        }
    }
}
