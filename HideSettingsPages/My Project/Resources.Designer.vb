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
        '''  Looks up a localized string similar to {\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1033{\fonttbl{\f0\fnil\fcharset0 Calibri;}{\f1\fnil\fcharset2 Symbol;}}
        '''{\*\generator Riched20 10.0.14393}\viewkind4\uc1 
        '''\pard\sl240\slmult1\qc\b\f0\fs10\lang9\par
        '''
        '''\pard\sl276\slmult1\qc\fs32 UXL Launcher Acknowledgements\b0\par
        '''
        '''\pard\sl360\slmult1\fs24\par
        '''
        '''\pard{\pntext\f1\&apos;B7\tab}{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\&apos;B7}}\fi-360\li720\sl360\slmult1 Original idea: God\par
        '''{\pntext\f1\&apos;B7\tab}Moral support: My mom, Nana, Mitty, and all my friend [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property Acknowledgements_RTF() As String
            Get
                Return ResourceManager.GetString("Acknowledgements_RTF", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 2017-04-13T23:28:16
        '''.
        '''</summary>
        Friend ReadOnly Property BuildDate() As String
            Get
                Return ResourceManager.GetString("BuildDate", resourceCulture)
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
        Friend ReadOnly Property gpl_rtf() As String
            Get
                Return ResourceManager.GetString("gpl_rtf", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
