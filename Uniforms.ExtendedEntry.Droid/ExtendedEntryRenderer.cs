using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Uniforms.ExtendedEntry;
using Uniforms.ExtendedEntry.Droid;

[assembly: ExportRenderer(typeof(ExtendedEntry), typeof(ExtendedEntryRenderer))]

namespace Uniforms.ExtendedEntry.Droid
{
    using Console = System.Diagnostics.Debug;

    /// <summary>
    /// Class ExtendedEntryRenderer.
    /// </summary>
    public class ExtendedEntryRenderer : EntryRenderer
    {
        Android.Graphics.Drawables.Drawable defaultBackground;

        /// <summary>
        /// Empty method for reference
        /// </summary>
        public static void Init ()
        { }

        /// <summary>
        /// Handles the element changed event.
        /// </summary>
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null) {
                UpdateBorder ();
                UpdateStyles ();
            }
        }

        /// <summary>
        /// Handles the element property changed event.
        /// </summary>
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
        
            if (e.PropertyName == ExtendedEntry.HasBorderProperty.PropertyName) {
                UpdateBorder ();
            }
        }

        /// <summary>
        /// Sets the border.
        /// </summary>
        void UpdateBorder ()
        {
            if (defaultBackground == null) {
                defaultBackground = Control.Background;
            }

            if ((Element as ExtendedEntry).HasBorder) {
                if (defaultBackground != null) {
                    Control.SetBackground (defaultBackground);
                }
            } else {
                Control.SetBackgroundColor (Android.Graphics.Color.Transparent);
            }
        }

        void UpdateStyles ()
        {
            Console.WriteLine ($"ExtendedEntryRenderer: UpdateStyles: {Element.StyleClass}");

            if (Element.StyleClass != null) {
                var entry = Element as ExtendedEntry;
                       
                foreach (var style in Element.StyleClass) {
                    switch (style) {
                    case ExtendedEntry.NoBorderStyle:
                        entry.HasBorder = false;
                        break;
                    case ExtendedEntry.PlainCellStyle:
                        entry.HasBorder = true;
                        break;
                    }
                }
            }
        }

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
