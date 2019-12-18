// Copyright 2019 MaidSafe.net limited.
//
// This SAFE Network Software is licensed to you under the MIT license <LICENSE-MIT
// https://opensource.org/licenses/MIT> or the Modified BSD license <LICENSE-BSD
// https://opensource.org/licenses/BSD-3-Clause>, at your option. This file may not be copied,
// modified, or distributed except according to those terms. Please review the Licences for the
// specific language governing permissions and limitations relating to use of the SAFE Network
// Software.

using Xamarin.Essentials;

namespace MobileSnapp.Helpers
{
    public class AppPreferencesHelper
    {
        private const string IsBrowserInstalledKey = "IsBrowserInstalled";

        public static bool IsBrowserInstalled
        {
            get => Preferences.Get(IsBrowserInstalledKey, false);
            set => Preferences.Set(IsBrowserInstalledKey, value);
        }

        public static void ClearIsBrowserInstallPreference() => Preferences.Remove(IsBrowserInstalledKey);

        public static void ClearAllAppPreferences() => Preferences.Clear();
    }
}
