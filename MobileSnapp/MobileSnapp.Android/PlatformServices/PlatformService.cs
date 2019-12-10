using System;
using System.Linq;
using Android.Content;
using MobileSnapp.Droid.PlatformServices;
using MobileSnapp.Services;
using Plugin.CurrentActivity;
using Xamarin.Forms;

[assembly: Dependency(typeof(PlatformService))]

namespace MobileSnapp.Droid.PlatformServices
{
    public class PlatformService : IPlatformService
    {
        private string _browserPackageId = "hello.maidsafe.browser";

        public bool CanOpenAnAppUsingUrl(string appUrl)
        {
            try
            {
                var packageManager = CrossCurrentActivity.Current.AppContext.PackageManager;
                var isBrowserUrl = appUrl.StartsWith("safe://", StringComparison.Ordinal);
                if (isBrowserUrl && packageManager != null)
                {
                    var packageInfo = packageManager.GetPackageInfo(
                        _browserPackageId,
                        Android.Content.PM.PackageInfoFlags.Activities);
                    if (packageInfo != null)
                    {
                        return true;
                    }
                }

                var aUri = Android.Net.Uri.Parse(appUrl);
                var intent = new Intent(Intent.ActionView, aUri);

                if (packageManager != null)
                {
                    var activities = packageManager.QueryIntentActivities(
                           intent,
                           0);
                    var isIntentSafe = activities != null && activities.Any();
                    return isIntentSafe;
                }

                return false;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
