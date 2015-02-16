using System;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace ZeroFiveBit.Forms.ExtendedEntry
{
    /// <summary>
    /// An extended entry control that allows the Font and text X alignment to be set
    /// </summary>
    public class ExtendedEntry : Entry
    {
        /// <summary>
        /// The Font property.
        /// </summary>
        public static readonly BindableProperty FontProperty =
            BindableProperty.Create("Font", typeof(Font), typeof(ExtendedEntry), new Font());

        /// <summary>
        /// The XAlign property.
        /// </summary>
        public static readonly BindableProperty XAlignProperty =
            BindableProperty.Create("XAlign", typeof(TextAlignment), typeof(ExtendedEntry), 
                TextAlignment.Start);

        /// <summary>
        /// The HasBorder property.
        /// </summary>
        public static readonly BindableProperty HasBorderProperty =
            BindableProperty.Create("HasBorder", typeof(bool), typeof(ExtendedEntry), true);

        /// <summary>
        /// The PlaceholderTextColor property.
        /// </summary>
        public static readonly BindableProperty PlaceholderTextColorProperty =
            BindableProperty.Create("PlaceholderTextColor", typeof(Color), typeof(ExtendedEntry), Color.Default);

        /// <summary>
        /// The CursorColorProperty property.
        /// </summary>
        public static readonly BindableProperty CursorColorProperty =
            BindableProperty.Create("CursorColor", typeof(Color), typeof(ExtendedEntry), Color.Default);

        /// <summary>
        /// Gets or sets the Font.
        /// </summary>
        public Font Font
        {
            get { return (Font)GetValue(FontProperty); }
            set { SetValue(FontProperty, value); }
        }

        /// <summary>
        /// Gets or sets the X alignment of the text.
        /// </summary>
        public TextAlignment XAlign
        {
            get { return (TextAlignment)GetValue(XAlignProperty); }
            set { SetValue(XAlignProperty, value); }
        }

        /// <summary>
        /// Gets or sets if the border should be shown or not.
        /// </summary>
        public bool HasBorder
        {
            get { return (bool)GetValue(HasBorderProperty); }
            set { SetValue(HasBorderProperty, value); }
        }

        /// <summary>
        /// Gets or sets color for placeholder text.
        /// </summary>
        public Color PlaceholderTextColor
        {
            get { return (Color)GetValue(PlaceholderTextColorProperty); }
            set { SetValue(PlaceholderTextColorProperty, value); }
        }

        /// <summary>
        /// Gets or sets color for placeholder text.
        /// </summary>
        public Color CursorColor
        {
            get { return (Color)GetValue(CursorColorProperty); }
            set { SetValue(CursorColorProperty, value); }
        }
    }
}

