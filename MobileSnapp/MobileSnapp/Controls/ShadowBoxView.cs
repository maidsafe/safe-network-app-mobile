﻿using Xamarin.Forms;

namespace MobileSnapp.Controls
{
    public enum ShadowType
    {
        None = 0,
        Top,
        Bottom
    }

    public class ShadowBoxView : BoxView
    {
        public static readonly BindableProperty ShadowTypeProperty = BindableProperty.Create(
            nameof(ShadowType),
            typeof(ShadowType),
            typeof(ShadowBoxView));

        public ShadowType ShadowType
        {
            get => (ShadowType)GetValue(ShadowTypeProperty);
            set => SetValue(ShadowTypeProperty, value);
        }
    }
}
