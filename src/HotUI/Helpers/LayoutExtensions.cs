﻿using System;
namespace HotUI
{
	public static class LayoutExtensions
    {
	    /// <summary>
	    /// Set the padding to the default thickness.
	    /// </summary>
	    /// <param name="view"></param>
	    /// <typeparam name="T"></typeparam>
	    /// <returns></returns>
        public static T Padding<T>(this T view) where T : View
        {
            var defaultThickness = new Thickness(10);
            return view.Padding(defaultThickness);
        }

	    /// <summary>
	    /// Set the padding to a specified thickness.
	    /// </summary>
	    /// <param name="view"></param>
	    /// <param name="padding"></param>
	    /// <typeparam name="T"></typeparam>
	    /// <returns></returns>
        public static T Padding<T> (this T view, Thickness padding) where T : View
		{
			view.SetEnvironment (EnvironmentKeys.Layout.Padding, padding);
			return view;
		}

	    public static Thickness GetPadding (this View view)
	    {
		    return view.GetPadding(Thickness.Empty);
	    }
	    
		public static Thickness GetPadding (this View view, Thickness defaultPadding)
		{
			var padding = view.GetEnvironment<Thickness?> (EnvironmentKeys.Layout.Padding);
			if (padding != null)
				return (Thickness)padding;

            if (view.BuiltView != null)
                return view.BuiltView.GetPadding(defaultPadding);

			return defaultPadding;
		}
		
		public static T Overlay<T> (this T view, View overlayView) where T : View
		{
			view.SetEnvironment (EnvironmentKeys.View.Overlay, overlayView);
			return view;
		}
		
		public static T Overlay<T> (this T view, Shape shape) where T : View
		{
            var shapeView = new ShapeView(shape);
			view.SetEnvironment (EnvironmentKeys.View.Overlay, shapeView);
			return view;
		}

        public static View GetOverlay(this View view)
        {
            return view.GetEnvironment<View>(EnvironmentKeys.View.Overlay);
        }
    }
}
