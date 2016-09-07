# ExtendedEntry

Extended Entry class for Xamarin.Forms

## Why?

There's a quite mature project [https://github.com/XLabs/Xamarin-Forms-Labs](https://github.com/XLabs/Xamarin-Forms-Labs) and you probably would better use their solution.

This is a friendly fork made for several reasons:

1. Xamarin.Forms is evolving fast, so we need 3rd party libs and tools to release often. For that reason a set of small projects is better than single big framework-like library.

2. Personally me is not really great at C# / Xamarin.Forms yet, but I need to extend some functionality of original libs. So it's more comfortable for me to do it in separate fork and not pullute original project with unperfect code.

3. It's a good way for me to get better with reusable libraries development workflow. It seems like most of tools and docs are targeting Windows / Visual Studio developers. And I code on Mac OS / Xamarin Studio, which is more likely uncharted territory sometimes. So I have a chance to explore and improve things in this area.

## Documentation

``ExtendedEntry`` class is a subclass of ``Xamarin.Forms.Entry`` with several extra features:

- HasBorder, HasBorderProperty
- CursorColor, CursorColorProperty
