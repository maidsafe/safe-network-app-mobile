// Copyright 2019 MaidSafe.net limited.
//
// This SAFE Network Software is licensed to you under the MIT license <LICENSE-MIT
// https://opensource.org/licenses/MIT> or the Modified BSD license <LICENSE-BSD
// https://opensource.org/licenses/BSD-3-Clause>, at your option. This file may not be copied,
// modified, or distributed except according to those terms. Please review the Licences for the
// specific language governing permissions and limitations relating to use of the SAFE Network
// Software.

using System.Collections.ObjectModel;
using System.Windows.Input;
using MobileSnapp.Helpers;
using MobileSnapp.Models.Onboarding;
using MobileSnapp.Views.Onboarding;
using MvvmHelpers;
using Xamarin.Forms;

namespace MobileSnapp.ViewModels.Onboarding
{
    public class CreateAccountOnboardingViewModel : BaseViewModel
    {
        #region Fields

        private const string _staticContentFile = "CreateAccountOnboarding.json";

        private int _carouselViewCurrentPosition;

        private ObservableCollection<CreateAccountOnboardingItem> _onBordingOptions;

        private INavigation _navigation;

        #endregion

        #region Constructor

        public CreateAccountOnboardingViewModel(INavigation navigation)
        {
            _navigation = navigation;
            OnBordingOptions = new ObservableCollection<CreateAccountOnboardingItem>(
                ContentHelpers.PopulateData<CreateAccountOnboardingStaticContent>(
                    _staticContentFile)
                .CreateAccountOnboarding);
            BackCommand = new Command(
                () => CarouselViewCurrentPosition -= 1,
                () => CarouselViewCurrentPosition > 0);
            NextCommand = new Command(
                () =>
                {
                    if (CarouselViewCurrentPosition == 2)
                        _navigation.PushAsync(new CreateAccountOptionsPage());
                    else
                        CarouselViewCurrentPosition += 1;
                },
                () => CarouselViewCurrentPosition <= 2);
        }

        private void ShowNextItem(object arg)
        {
            --CarouselViewCurrentPosition;
        }

        private void ShowPreviousItem(object arg)
        {
            ++CarouselViewCurrentPosition;
        }

        #endregion

        #region Commands

        /// <summary>
        /// Gets or sets the command that is executed when the Back button is clicked.
        /// </summary>
        public ICommand BackCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the Done button is clicked.
        /// </summary>
        public ICommand NextCommand { get; set; }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or set the create account onboarding item.
        /// </summary>
        public ObservableCollection<CreateAccountOnboardingItem> OnBordingOptions
        {
            get => _onBordingOptions;
            set => SetProperty(ref _onBordingOptions, value);
        }

        public int CarouselViewCurrentPosition
        {
            get => _carouselViewCurrentPosition;
            set => SetProperty(ref _carouselViewCurrentPosition, value);
        }

        #endregion
    }
}
