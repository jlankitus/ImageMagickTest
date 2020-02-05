# ImageMagickTest
Test using ImageMagick .Net Wrapper in Unity for Mac OSX

## Working Setup Replication Steps (Already done in Master):

- Download ImageMagick 7.14.1 from Nuget.
- Import dll and xml file from netstandard20 folder
- Import all runtime binaries
- Change Magick.Native-Q16-HDRI-x64.dll.dylib to Magick.Native-Q16-HDRI-x64.dll.bundle

## Branch Status:

### Master
Works using Unity 2019.1.10 to 2019.1.14. Uses ImageMagick 7.14.1
The dlls are all found in the plugins folder, and were dragged there from the packages folder after downloading via nuget.
The Mac dll that in later version cannot be found must have its extension changed from .dylib to .bundle for this to work properly (Saved like this in repo).

### 2019.3-upgrade-main-problem
Same master code, but this breaks when updating to any Unity 2019.2+. This is the main problem to fix! Tested on 2019.3 and this also does not work. 

### 2019.1-Q8-Test
This exchanges the Q16-AnyCPU plugin for the Q8-64x. This was recommended here: https://unitycoder.com/blog/2017/01/27/using-imagemagick-with-unity/

This works exclusively in 2019.1.x

### 2019.3-Q8-Test
Simple editor upgrade from the 2019.1-Q8 branch. This doesn't work, also cannot find the mac dll. 

### 2019.1.10-image-magick-7.15.1
Testing upgrading the image magick plugin to 7.15.1. Has an error with actual usage, but not due to missing dll.

### 2019.3.test-imagemagick-7.15.1
Fails due to missing dll still. 

### 2019.3-dylib-test
Continuation off master, where I reimported the mac binary as regular dylib file. Still fails upon Unity upgrade.
