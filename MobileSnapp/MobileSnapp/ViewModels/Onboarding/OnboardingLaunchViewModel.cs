<<<<<<< HEAD
﻿// Copyright 2019 MaidSafe.net limited.
//
// This SAFE Network Software is licensed to you under the MIT license <LICENSE-MIT
// https://opensource.org/licenses/MIT> or the Modified BSD license <LICENSE-BSD
// https://opensource.org/licenses/BSD-3-Clause>, at your option. This file may not be copied,
// modified, or distributed except according to those terms. Please review the Licences for the
// specific language governing permissions and limitations relating to use of the SAFE Network
// Software.

using System.Collections.ObjectModel;
using System.Windows.Input;
=======
﻿using System.Collections.ObjectModel;
>>>>>>> refactor(homePage): refactor font and unnecessary code
using MobileSnapp.Helpers;
using MobileSnapp.Models.Onboarding;
using MvvmHelpers;

namespace MobileSnapp.ViewModels.Onboarding
{
    /// <summary>
    /// ViewModel for on-boarding gradient page.
    /// </summary>
    public class OnBoardingLaunchViewModel : BaseViewModel
    {
        #region Fields

        private const string _staticContentFile = "OnboardingLaunch.json";

        private ObservableCollection<CarouselItem> boardings;

        #endregion

        #region Constructor

        public OnBoardingLaunchViewModel()
        {
            OnBoardingLaunchItems = new ObservableCollection<CarouselItem>(
               ContentHelpers.PopulateData<OnboardingLaunch>(
                   _staticContentFile)
               .CarouselItems);
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the boardings collection.
        /// </summary>
        public ObservableCollection<CarouselItem> OnBoardingLaunchItems
        {
            get => boardings;
            set => SetProperty(ref boardings, value);
        }

        #endregion
    }
}
