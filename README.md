# HideSettingsPages
GUI to set a Registry key value to hide individual pages in the Windows 10 Settings app on the Creators Update and newer.


Thanks to Microsoft for implementing this feature into Windows 10, Windows Central for posting an article on [how to use this feature](http://www.windowscentral.com/how-hide-settings-pages-windows-10-creators-update), and a commenter going by the name of ["DragonPoo" for the indirect suggestion](http://www.windowscentral.com/how-hide-settings-pages-windows-10-creators-update#comment-2761513).

Currently, HideSettingsPages allows users to easily hide (or only show while the rest are hidden) certain pages without potentially causing problems with the Windows Registry. In conjunction with HideSettingsPages Registry Helper, it does this by writing the user's choice of pages to a value named <code>SettingsPageVisibility</code> located at <code>HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer\ </code> in the Windows Registry.


Screenshot:

![](/docs/images/HideSettingsPages-0.3-screenshot.png?raw=true)

As you can see, the GUI is mostly complete. HideSettingsPages can, as of May 18, 2017, generate the necessary Registry key value that hides (or only shows) pages in the Settings app. I'll have to make the Apply and Undo buttons at the bottom actually do what they're supposed to do, along with adding an About window. You may also notice this app is running on Windows 7. Although this app can run on any version of Windows supported by the .Net Framework 4.6.1, the Registry key value it modifies/sets only does things on PCs running the Windows 10 Creators Update or higher.

<br>
<br>

# System Requirements

## System Requirements for running HideSettingsPages

To run HideSettingsPages, your computer requires the following:

- HideSettingsPages Registry Helper. This is included with HideSettingsPages and is what applies the Registry key value to hide the pages the user chooses. It's sometimes refered to as "hsp_registry-helper" as that's the filename I chose for it.

- [Microsoft .Net 4.6.1 Framework](https://www.microsoft.com/en-us/download/details.aspx?id=49981)

  - Ignore the ad on that page, scroll down, and click the orange Download button. Note that this is the web installer and it'll download its components after it's opened. May take a while to download.

- Windows versions: Windows 7 SP1, 10.
  - Windows 8.0 and Windows 8.1 are untested although they might work. HideSettingsPages is intended to be used on Windows 10 Creators Update and above, though it does work on Windows 7 SP1.

- Architectures: x86 (32-bit) and x64 (64-bit.)

- Hardware requirements: At least a 1.2 GHz CPU; 1 GB of RAM or more.

- Disk space:

  - 32-bit: 3 GB space free.
  - 64-bit: 3 GB space free.

- Note that you might have problems with running this on corporate computers. The ClickOnce security settings are disabled in HideSettingsPages and HideSettingsPages Registry Helper due to Visual Studio building problems.

## Building HideSettingsPages from Source: System Requirements and Guide

In addition to the requirements for simply running HideSettingsPages, your computer requires the following software to build it from source code:

- [Microsoft Build Tools 2015](https://www.microsoft.com/en-us/download/details.aspx?id=48159)
- [Windows PowerShell 5.0](https://www.microsoft.com/en-us/download/details.aspx?id=50395)

If [Visual Studio 2015 Community](https://www.visualstudio.com/vs/) is installed, Microsoft Build Tools 2015 is not required for building HideSettingsPages.

***

Here's how to manually build HideSettingsPages:

1. First, clone the Git repository by running: <code>git clone https://github.com/DrewNaylor/HideSettingsPages.git</code> or [download the Zip file for the master branch](https://github.com/DrewNaylor/HideSettingsPages/archive/master.zip) and remember where you saved your files.

2. Next, open the command prompt from the Start menu (<code>cmd.exe</code>) and type or copy/paste <code>cd C:\Program Files (x86)\MSBuild\14.0\Bin\ </code> if you have a 64-bit Windows install or <code>cd C:\Program Files\MSBuild\14.0\Bin\ </code> if you have a 32-bit Windows install. Press the Enter or Return key when it's pasted. Don't run <code>cmd.exe</code> from the Git Shell or else the next step won't work.

3. Third, type <code>msbuild.exe</code>, press the spacebar, and drag the <code>HideSettingsPages.sln</code> file into the command prompt window and press the Enter or Return key. This file may be in <code>HideSettingsPages-[branch]\HideSettingsPages-[branch]\ </code>. [branch] is the branch cloned from, in this case master.

4. And finally, once the solution is done being built, you'll find both the main HideSettingsPages EXE file and the hsp_registry-helper EXE file in <code>HideSettingsPages-[branch]\HideSettingsPages-[branch]\HideSettingsPages\bin\Debug </code> wherever you saved the files to earlier along with a config file, a PDB file, and an XML file for both EXE files. You'll also find a Windows Registry Editor file to undo any modifications to the Registry key value that hides Settings app pages, if necessary. [branch] is the branch cloned from, in this case master.

5. Double-click on <code>HideSettingsPages.exe</code> to open the main HideSettingsPages GUI.

## How to Modify the Source Code

In order to play around with the source code, it's recommended to install [Visual Studio 2015 Community](https://www.visualstudio.com/vs/) in addition to the software to run HideSettingsPages. To poke around in the code, simply double-click the <code>HideSettingsPages.sln</code> file in the root of the Git repository.
