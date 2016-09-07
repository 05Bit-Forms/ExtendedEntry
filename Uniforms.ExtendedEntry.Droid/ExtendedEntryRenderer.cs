using System;
using System.ComponentModel;
using Android.Views;
using Android.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Uniforms.ExtendedEntry;
using Uniforms.ExtendedEntry.Droid;

[assembly: ExportRenderer(typeof(ExtendedEntry), typeof(ExtendedEntryRenderer))]

namespace Uniforms.ExtendedEntry.Droid
{
    /// <summary>
    /// Class ExtendedEntryRenderer.
    /// </summary>
    public class ExtendedEntryRenderer : EntryRenderer
    {
        /// <summary>
        /// Empty method for reference
        /// </summary>
        public static void Init ()
        {
        }

        /// <summary>
        /// Handles the element changed event.
        /// </summary>
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            //if ((Control != null) && (Element != null)) {
            //    UpdateBorder ();
            //}

            Control.SetBackgroundColor(Android.Graphics.Color.Transparent);
        }

        /// <summary>
        /// Handles the element property changed event.
        /// </summary>
        //protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        //{
        //    base.OnElementPropertyChanged(sender, e);
        //
        //    if (e.PropertyName == ExtendedEntry.HasBorderProperty.PropertyName) {
        //        UpdateBorder ();
        //    }
        //}

        /// <summary>
        /// Sets the border.
        /// </summary>
        //void UpdateBorder ()
        //{
        //}

//        /// <summary>
//        /// Sets the MaxLength characteres.
//        /// </summary>
//        /// <param name="view">The view.</param>
//        private void SetMaxLength(ExtendedEntry view)
//        {
//            Control.SetFilters(new IInputFilter[] { new global::Android.Text.InputFilterLengthFilter(view.MaxLength) });
//        }
    }
}
