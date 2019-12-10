using Foundation;
using MobileSnapp.iOS.PlatformServices;
using MobileSnapp.Services;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(PlatformService))]

namespace MobileSnapp.iOS.PlatformServices
{
    public class PlatformService : IPlatformService
    {
        public bool CanOpenAnAppUsingUrl(string appUrl)
        {
            return UIApplication.SharedApplication.CanOpenUrl(new NSUrl(appUrl));
        }
    }
}
