# HideSettingsPages
GUI for setting a Registry key to hide individual pages in the Windows 10 Settings app on the Creators Update and newer.


Thanks to Microsoft for implementing this feature into Windows 10, Windows Central for posting an article on [how to use this feature](http://www.windowscentral.com/how-hide-settings-pages-windows-10-creators-update), and a commenter going by the name of ["DragonPoo" for the indirect suggestion](http://www.windowscentral.com/how-hide-settings-pages-windows-10-creators-update#comment-2761513).

Currently, HideSettingsPages is just a GUI and the only actual code is used to update the titlebar. However, the goal for HideSettingsPages is to allow users to easily hide (or only show while the rest are hidden) certain pages without potentially causing problems with the Windows Registry.


Screenshot:

![](/docs/images/HideSettingsPages-v0.1-screenshot.png?raw=true)

As you can see, the GUI isn't fully complete yet. I'll have to change the text on the checkboxes to all the pages Microsoft allows users to disable. You may also notice this app is running on Windows 7. Although this app can run on any version of Windows supported by the .Net Framework 4.6.1, the Registry key it modifies/sets only does things on PCs running the Windows 10 Creators Update or higher.