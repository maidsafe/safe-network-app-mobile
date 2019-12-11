// Copyright 2019 MaidSafe.net limited.
//
// This SAFE Network Software is licensed to you under the MIT license <LICENSE-MIT
// https://opensource.org/licenses/MIT> or the Modified BSD license <LICENSE-BSD
// https://opensource.org/licenses/BSD-3-Clause>, at your option. This file may not be copied,
// modified, or distributed except according to those terms. Please review the Licences for the
// specific language governing permissions and limitations relating to use of the SAFE Network
// Software.

﻿using MobileSnapp.Views.Onboarding;
﻿using Xamarin.Forms;

﻿namespace MobileSnapp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var launchPageTitleBarColor = (Color)Application.Current.Resources["PrimaryColor-800"];
            MainPage = new NavigationPage(new OnboardingLaunchPage())
            {
                BarBackgroundColor = launchPageTitleBarColor
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
