// Copyright 2019 MaidSafe.net limited.
//
// This SAFE Network Software is licensed to you under the MIT license <LICENSE-MIT
// https://opensource.org/licenses/MIT> or the Modified BSD license <LICENSE-BSD
// https://opensource.org/licenses/BSD-3-Clause>, at your option. This file may not be copied,
// modified, or distributed except according to those terms. Please review the Licences for the
// specific language governing permissions and limitations relating to use of the SAFE Network
// Software.

using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using MobileSnapp.Helpers;
using MobileSnapp.Models.Onboarding;
using MobileSnapp.ViewModels.Common;
using MobileSnapp.Views.Onboarding;
using Xamarin.Forms;

namespace MobileSnapp.ViewModels.Onboarding
{
    /// <summary>
    /// ViewModel for on-boarding gradient page.
    /// </summary>
    public class OnBoardingLaunchViewModel : BaseViewModel
    {
        #region Fields

        private const string _staticContentFile = "OnboardingLaunch.json";

        private ObservableCollection<CarouselItem> _boardings;

        private INavigation _navigation;

        public ICommand CarouselViewItemTapCommand { get; }

        public ICommand OpenLoginPageCommand { get; }

        #endregion

        #region Constructor

        public OnBoardingLaunchViewModel(INavigation navigation)
        {
            _navigation = navigation;
            IsBrowserInstalled = AppPreferencesHelper.IsBrowserInstalled;

            OnBoardingLaunchItems = new ObservableCollection<CarouselItem>(
               ContentHelpers.PopulateData<OnboardingLaunch>(
                   _staticContentFile)
               .CarouselItems);

            CarouselViewItemTapCommand = new Command(PerformCarouselViewItemTapAction);
            OpenLoginPageCommand = new Command(ShowLoginPage);

            // Check is the browser is install
            var canOpenTestUrl = PlatformService.CanOpenAnAppUsingUrl("safe://testapp.net");
            if (canOpenTestUrl)
            {
                IsBrowserInstalled = true;
                AppPreferencesHelper.IsBrowserInstalled = true;
            }
        }

        private void ShowLoginPage()
        {
            _navigation.PushModalAsync(new NavigationPage(new LoginPage())
            {
                BarBackgroundColor = Color.White
            });
        }

        private void PerformCarouselViewItemTapAction(object secondaryTitle)
        {
            if (secondaryTitle is null)
                return;

            var tappedItem = OnBoardingLaunchItems.FirstOrDefault(t => t.SecondaryTitle == (secondaryTitle as string));
            if (tappedItem != null)
            {
                ContentPage newActivePage = null;
                switch (tappedItem.SecondaryTitle.ToLower())
                {
                    case "explore":
                        newActivePage = new AppDetailsPage();
                        break;
                    case "get involved":
                        newActivePage = new CreateAccountOnboardingPage();
                        break;
                    case "earn safecoin":
                        newActivePage = new LoginPage();
                        break;
                }

                if (newActivePage != null)
                {
                    _navigation.PushModalAsync(new NavigationPage(newActivePage)
                    {
                        BarBackgroundColor = Color.White
                    });
                }
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the boardings collection.
        /// </summary>
        public ObservableCollection<CarouselItem> OnBoardingLaunchItems
        {
            get => _boardings;
            set => SetProperty(ref _boardings, value);
        }

        private bool _isBrowserInstalled;

        public bool IsBrowserInstalled
        {
            get => _isBrowserInstalled;
            set => SetProperty(ref _isBrowserInstalled, value);
        }

        #endregion
    }
}
