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
        public bool CanOpenAnAppUsingUrl(string appUrl)
        {
            var aUri = Android.Net.Uri.Parse(appUrl);
            var intent = new Intent(Intent.ActionView, aUri);

            var packageManager = CrossCurrentActivity.Current.AppContext.PackageManager;

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
    }
}
