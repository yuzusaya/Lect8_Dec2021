using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Lect8V2.CustomRenderers
{
    public class CustomEntry : Entry
    {
        public static readonly BindableProperty AngleProperty = BindableProperty.Create(nameof(Angle), typeof(double), typeof(CustomEntry), null);
        public double Angle
        {
            get { return (double)GetValue(AngleProperty); }
            set { SetValue(AngleProperty, value); }
        }
    }
}
