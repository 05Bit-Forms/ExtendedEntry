// Cross-platform
using System;
using System.Drawing;
using System.ComponentModel;
using Xamarin.Forms;

// Platform specific
using Xamarin.Forms.Platform.iOS;
using UIKit;
using Foundation;

// Project
using ZeroFiveBit.Forms.ExtendedEntry;
using ZeroFiveBit.Forms.ExtendedEntry.iOS;

[assembly: ExportRenderer(typeof(ExtendedEntry), typeof(ExtendedEntryRenderer))]
namespace ZeroFiveBit.Forms.ExtendedEntry.iOS
{
    /// <summary>
    /// A renderer for the ExtendedEntry control.
    /// </summary>
    public class ExtendedEntryRenderer : EntryRenderer
    {
        /// <summary>
        /// The on element changed callback.
        /// </summary>
        /// <param name="e">The event arguments.</param>
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            var view = (ExtendedEntry)Element;

            if (view != null)
            {
                SetFont(view);
                SetTextAlignment(view);
                SetBorder(view);
                SetPlaceholderTextColor(view);
                SetCursorColor(view);
            }

            ResizeHeight();
        }

        /// <summary>
        /// The on element property changed callback
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="PropertyChangedEventArgs"/> instance containing the event data.</param>
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            var view = (ExtendedEntry)Element;

            if (e.PropertyName == ExtendedEntry.FontProperty.PropertyName)
            {
                SetFont(view);
            }
            else if (e.PropertyName == ExtendedEntry.XAlignProperty.PropertyName)
            {
                SetTextAlignment(view);
            }
            else if (e.PropertyName == ExtendedEntry.HasBorderProperty.PropertyName)
            {
                SetBorder(view);
            }
            else if (e.PropertyName == ExtendedEntry.PlaceholderTextColorProperty.PropertyName)
            {
                SetPlaceholderTextColor(view);
            }
            else if (e.PropertyName == ExtendedEntry.CursorColorProperty.PropertyName)
            {
                SetCursorColor(view);
            }

            ResizeHeight();
        }

        /// <summary>
        /// Sets the text alignment.
        /// </summary>
        /// <param name="view">The view.</param>
        private void SetTextAlignment(ExtendedEntry view)
        {
            switch (view.XAlign)
            {
                case TextAlignment.Center:
                    Control.TextAlignment = UITextAlignment.Center;
                    break;

                case TextAlignment.End:
                    Control.TextAlignment = UITextAlignment.Right;
                    break;

                case TextAlignment.Start:
                    Control.TextAlignment = UITextAlignment.Left;
                    break;
            }
        }

        /// <summary>
        /// Sets the font.
        /// </summary>
        /// <param name="view">The view.</param>
        private void SetFont(ExtendedEntry view)
        {
            UIFont uiFont;
            if (view.Font != Font.Default && (uiFont = view.Font.ToUIFont()) != null)
            {
                Control.Font = uiFont;
            }
            else if (view.Font == Font.Default)
            {
                Control.Font = Font.Default.ToUIFont();
            }
        }

        /// <summary>
        /// Sets the border.
        /// </summary>
        /// <param name="view">The view.</param>
        private void SetBorder(ExtendedEntry view)
        {
            Control.BorderStyle = view.HasBorder ? UITextBorderStyle.RoundedRect : UITextBorderStyle.None;
        }

        /// <summary>
        /// Resizes the height.
        /// </summary>
        private void ResizeHeight()
        {
            if (Element != null)
            {
                if (Element.HeightRequest >= 0) return;

                var height = Math.Max(Bounds.Height,
                    new UITextField {Font = Control.Font}.IntrinsicContentSize.Height);

                Control.Frame = new RectangleF(0.0f, 0.0f, (float)Element.Width, (float)height);

                Element.HeightRequest = height;
            }
        }

        /// <summary>
        /// Sets the color of the placeholder text.
        /// </summary>
        /// <param name="view">The view.</param>
        void SetPlaceholderTextColor(ExtendedEntry view)
        {
            if(string.IsNullOrEmpty(view.Placeholder) == false && view.PlaceholderTextColor != Color.Default)
            {
                NSAttributedString placeholderString = new NSAttributedString(
                    view.Placeholder, new UIStringAttributes { ForegroundColor = view.PlaceholderTextColor.ToUIColor() });
                Control.AttributedPlaceholder = placeholderString;
            }
        }

        /// <summary>
        /// Sets the color of the cursor.
        /// </summary>
        void SetCursorColor(ExtendedEntry view)
        {
            if (view.CursorColor != Color.Default)
            {
                Control.TintColor = view.CursorColor.ToUIColor();
            }
        }
    }
}

