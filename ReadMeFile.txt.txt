If you get error while building the solution please do the followings:
===============================================================================

Just checked: nuget.targets is an msbuild file. And you were on the right way, in:

<DownloadNuGetExe Condition=" '$(DownloadNuGetExe)' == '' ">false</DownloadNuGetExe>

Change the value to true:

<DownloadNuGetExe Condition=" '$(DownloadNuGetExe)' == '' ">true</DownloadNuGetExe>

But you must restart Visual Studio or reload the solution (see comments) after this to take effect.