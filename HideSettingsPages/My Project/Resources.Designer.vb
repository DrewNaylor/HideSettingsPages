﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("HideSettingsPages.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to {\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1033{\fonttbl{\f0\fnil\fcharset0 Calibri;}{\f1\fswiss\fprq2\fcharset0 Calibri;}{\f2\fnil\fcharset2 Symbol;}}
        '''{\colortbl ;\red0\green0\blue255;}
        '''{\*\generator Riched20 10.0.17134}\viewkind4\uc1 
        '''\pard\sl240\slmult1\qc\b\f0\fs10\lang9\par
        '''
        '''\pard\sl276\slmult1\qc\fs32 HideSettingsPages Acknowledgements\b0\par
        '''
        '''\pard\sl360\slmult1\fs24\par
        '''
        '''\pard{\pntext\f2\&apos;B7\tab}{\*\pn\pnlvlblt\pnf2\pnindent0{\pntxtb\&apos;B7}}\fi-360\li720\sl360\slmult1\f1\lang1033 Guidanc [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property Acknowledgements_RTF() As String
            Get
                Return ResourceManager.GetString("Acknowledgements_RTF", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 2019-11-07T23:00:16
        '''.
        '''</summary>
        Friend ReadOnly Property BuildDate() As String
            Get
                Return ResourceManager.GetString("BuildDate", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;UXL_Launcher_Theme&gt;
        '''  &lt;Title&gt;Default Theme&lt;/Title&gt;
        '''  &lt;Description&gt;Default is the theme UXL Launcher ships with.&lt;/Description&gt;
        '''  &lt;Version&gt;v1.1&lt;/Version&gt;
        '''  &lt;Author&gt;Drew Naylor&lt;/Author&gt;
        '''
        '''  &lt;!-- &quot;UseThemeEngineVersion&quot; is used to specify the version of the
        '''  UXL Launcher Theme Engine to use in case there are changes in newer
        '''  versions of the theme engine that designers or developers don&apos;t want
        '''  to use. Version 1.01 is the oldest version number available and anything
        '''  smaller than that will automat [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property DefaultTheme_XML() As String
            Get
                Return ResourceManager.GetString("DefaultTheme_XML", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Make sure that at least one file in this folder exists at any given time. PowerShell complains about a folder not existing if I try to use the BuildDate thing without this directory here. If this text document is here, then Git will download the Resources folder like it should even if every other file in here is auto-generated and on the gitignore..
        '''</summary>
        Friend ReadOnly Property dummyfile() As String
            Get
                Return ResourceManager.GetString("dummyfile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to {\rtf1\ansi\deff0\nouicompat{\fonttbl{\f0\fswiss Helvetica;}{\f1\fswiss\fcharset0 Helvetica;}{\f2\fnil Courier;}}
        '''{\colortbl ;\red0\green0\blue255;}
        '''{\*\generator Riched20 10.0.14393}\viewkind4\uc1 
        '''\pard\sa180\b\f0\fs28\lang9 GNU GENERAL PUBLIC LICENSE\par
        '''\b0\fs24 Version 3, 29 June 2007\par
        '''Copyright \f1\&apos;a9 2007 Free Software Foundation, Inc. &lt;{{\field{\*\fldinst{HYPERLINK &quot;http://fsf.org/&quot;}}{\fldrslt{http://fsf.org/\ul0\cf0}}}}\f1\fs24 &gt;\par
        '''\f0 Everyone is permitted to copy and distribute verbat [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property gpl_RTF() As String
            Get
                Return ResourceManager.GetString("gpl_RTF", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property HideSettingsPages_Banner() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("HideSettingsPages_Banner", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Copyright (C) 2017-2019 Drew Naylor. Lincensed under Gnu GPLv3+.
        '''
        '''HideSettingsPages is a GUI to set a Registry key value to hide individual pages in the Windows 10 Settings app on the Creators Update and newer.
        '''
        '''License notice:
        '''HideSettingsPages is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as
        '''published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
        '''
        '''HideSettingsPages is distribut [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property HideSettingsPagesInfo_TXT() As String
            Get
                Return ResourceManager.GetString("HideSettingsPagesInfo_TXT", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 
        '''HideSettingsPages Registry Helper is used to apply the Registry
        '''key value chosen in HideSettingsPages. Can also apply/remove
        '''key value via arguments and show the current value in the Registry, also with arguments.
        '''This key value will hide or show pages in the Windows 10 Settings app on the Creators Update and newer.
        '''
        '''HideSettingsPages Registry Helper is also known as hsp_registry-helper.
        '''
        '''License notice:
        '''hsp_registry-helper is free software: you can redistribute it and/or modify it under the terms [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property HSPRegistryHelperInfo_TXT() As String
            Get
                Return ResourceManager.GetString("HSPRegistryHelperInfo_TXT", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Beta.
        '''</summary>
        Friend ReadOnly Property isStable() As String
            Get
                Return ResourceManager.GetString("isStable", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to about
        '''activation
        '''appsfeatures
        '''appsforwebsites
        '''autoplay
        '''backup
        '''batterysaver
        '''bluetooth
        '''camera
        '''clipboard
        '''colors
        '''connecteddevices
        '''cortana
        '''cortana-talktocortana
        '''cortana-moredetails
        '''cortana-notifications
        '''cortana-permissions
        '''cortana-windowssearch
        '''crossdevice
        '''datausage
        '''dateandtime
        '''defaultapps
        '''delivery-optimization
        '''developers
        '''devices-touchpad
        '''display
        '''easeofaccess-audio
        '''easeofaccess-closedcaptioning
        '''easeofaccess-colorfilter
        '''easeofaccess-cursorandpointersize
        '''easeofaccess-display
        '''easeofac [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property pagesList_TXT() As String
            Get
                Return ResourceManager.GetString("pagesList_TXT", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ----------------------------------------------------------------------------------------.
        '''</summary>
        Friend ReadOnly Property separator() As String
            Get
                Return ResourceManager.GetString("separator", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;UXL_Launcher_Theme&gt;
        '''  &lt;Title&gt;Ten Dark&lt;/Title&gt;
        '''  &lt;Description&gt;A dark theme similar to Windows 10&apos;s &quot;Dark Mode&quot;.&lt;/Description&gt;
        '''  &lt;Version&gt;v1.1&lt;/Version&gt;
        '''  &lt;Author&gt;Drew Naylor&lt;/Author&gt;
        '''
        '''  &lt;!-- &quot;UseThemeEngineVersion&quot; is used to specify the version of the
        '''  UXL Launcher Theme Engine to use in case there are changes in newer
        '''  versions of the theme engine that designers or developers don&apos;t want
        '''  to use. Version 1.01 is the oldest version number available and anything
        '''  smaller than that will automati [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property TenDarkTheme_XML() As String
            Get
                Return ResourceManager.GetString("TenDarkTheme_XML", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
