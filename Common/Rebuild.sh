#!/bin/sh

rm ZeroFiveBit.Forms.ExtendedEntry*.dll
rm ZeroFiveBit.Forms.ExtendedEntry*.mdb
rm ZeroFiveBit.Forms.ExtendedEntry*.nupkg

cp ../ZeroFiveBit.Forms.ExtendedEntry/bin/Release/ZeroFiveBit.Forms.ExtendedEntry.dll* .
cp ../ZeroFiveBit.Forms.ExtendedEntry.Droid/bin/Release/ZeroFiveBit.Forms.ExtendedEntry.Droid.dll* .
cp ../ZeroFiveBit.Forms.ExtendedEntry.iOS/bin/Release/ZeroFiveBit.Forms.ExtendedEntry.iOS.dll* .

nuget pack ZeroFiveBit.Forms.ExtendedEntry.nuspec