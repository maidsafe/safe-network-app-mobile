using Android.Content;
using MobileSnapp.Controls;
using MobileSnapp.Droid.ControlRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ShadowBoxView), typeof(ShadowBoxViewRenderer))]

namespace MobileSnapp.Droid.ControlRenderers
{
    public class ShadowBoxViewRenderer : VisualElementRenderer<ShadowBoxView>
    {
        public ShadowBoxViewRenderer(Context context)
            : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<ShadowBoxView> e)
        {
            UpdateBackgroundColor();
        }

        protected override void UpdateBackgroundColor()
        {
            switch (Element.ShadowType)
            {
                case ShadowType.Top:
                    SetBackgroundResource(Resource.Drawable.top_shadow);
                    break;

                case ShadowType.Bottom:
                    SetBackgroundResource(Resource.Drawable.bottom_shadow);
                    break;
            }
        }
    }
}
