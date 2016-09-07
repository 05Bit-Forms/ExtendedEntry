#!/bin/sh

rm Uniforms.ExtendedEntry*.dll
rm Uniforms.ExtendedEntry*.mdb
rm Uniforms.ExtendedEntry*.nupkg

cp ../Uniforms.ExtendedEntry/bin/Release/Uniforms.ExtendedEntry.dll* .
cp ../Uniforms.ExtendedEntry.Droid/bin/Release/Uniforms.ExtendedEntry.Droid.dll* .
cp ../Uniforms.ExtendedEntry.iOS/bin/Release/Uniforms.ExtendedEntry.iOS.dll* .

nuget pack Uniforms.ExtendedEntry.nuspec