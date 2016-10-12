using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
//using Foundation;
using UIKit;
using Uniforms.ExtendedEntry;
using Uniforms.ExtendedEntry.iOS;

[assembly: ExportRenderer(typeof(ExtendedEntry), typeof(ExtendedEntryRenderer))]

namespace Uniforms.ExtendedEntry.iOS
{
    using Console = System.Diagnostics.Debug;

    /// <summary>
    /// A renderer for the ExtendedEntry control.
    /// </summary>
    public class ExtendedEntryRenderer : EntryRenderer
    {
        /// <summary>
        /// Empty method for reference
        /// </summary>
        public static new void Init ()
        { }

        /// <summary>
        /// The on element changed callback.
        /// </summary>
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null) {
                UpdateBorder ();
                UpdateCursorColor ();
                UpdateStyles ();
            }

            // ResizeHeight();
        }

        /// <summary>
        /// The on element property changed callback
        /// </summary>
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == ExtendedEntry.HasBorderProperty.PropertyName) {
                UpdateBorder ();
            } else if (e.PropertyName == ExtendedEntry.CursorColorProperty.PropertyName) {
                UpdateCursorColor ();
            }

            // ResizeHeight();
        }

        /// <summary>
        /// Sets the border.
        /// </summary>
        void UpdateBorder ()
        {
            var view = Element as ExtendedEntry;

            Control.BorderStyle = (view.HasBorder ?
                                   UITextBorderStyle.RoundedRect :
                                   UITextBorderStyle.None);
        }

        /// <summary>
        /// Resizes the height.
        /// </summary>
        //void ResizeHeight()
        //{
        //    if (Element != null)
        //    {
        //        if (Element.HeightRequest >= 0) return;

        //        var height = Math.Max(Bounds.Height,
        //            new UITextField {Font = Control.Font}.IntrinsicContentSize.Height);

        //        Control.Frame = new RectangleF(0.0f, 0.0f, (float)Element.Width, (float)height);

        //        Element.HeightRequest = height;
        //    }
        //}

        /// <summary>
        /// Sets the color of the cursor.
        /// </summary>
        void UpdateCursorColor ()
        {
            var view = Element as ExtendedEntry;

            if (view.CursorColor != Color.Default) {
                Control.TintColor = view.CursorColor.ToUIColor ();
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
                        entry.HasBorder = false;
                        break;
                    }
                }
            }
        }
    }
}

