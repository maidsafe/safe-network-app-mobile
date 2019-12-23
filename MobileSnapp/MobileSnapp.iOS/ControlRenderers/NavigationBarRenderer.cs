using MobileSnapp.iOS.ControlRenderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(NavigationPage), typeof(NavigationPageRenderer))]

namespace MobileSnapp.iOS.ControlRenderers
{
    public class NavigationPageRenderer : NavigationRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            if (Element == null)
                return;

            NavigationBar.Layer.ShadowColor = UIColor.Gray.CGColor;
            NavigationBar.Layer.ShadowOffset = new CoreGraphics.CGSize(0, 0);
            NavigationBar.Layer.ShadowOpacity = 1;
            NavigationBar.Layer.ShadowRadius = 3;

            if (NavigationItem?.BackBarButtonItem != null)
                NavigationItem.BackBarButtonItem.Title = " ";

            if (NavigationBar.BackItem != null)
                NavigationBar.BackItem.Title = " ";
        }
    }
}
