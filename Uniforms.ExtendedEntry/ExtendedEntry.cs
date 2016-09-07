using System;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace Uniforms.ExtendedEntry
{
    /// <summary>
    /// An extended entry control that allows the Font and text X alignment to be set
    /// </summary>
    public class ExtendedEntry : Entry
    {
        /// <summary>
        /// The HasBorder property.
        /// </summary>
        public static readonly BindableProperty HasBorderProperty =
            BindableProperty.Create("HasBorder", typeof(bool), typeof(ExtendedEntry), true);

        /// <summary>
        /// The CursorColorProperty property.
        /// </summary>
        public static readonly BindableProperty CursorColorProperty =
            BindableProperty.Create("CursorColor", typeof(Color), typeof(ExtendedEntry), Color.Default);

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
        public Color CursorColor
        {
            get { return (Color)GetValue(CursorColorProperty); }
            set { SetValue(CursorColorProperty, value); }
        }
    }
}

