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


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property ComboBoxIndex() As Integer
            Get
                Return CType(Me("ComboBoxIndex"),Integer)
            End Get
            Set
                Me("ComboBoxIndex") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("server=DESKTOP-RIO;database=local_stock;port=3306;user id=rio;password=speech123;"& _ 
            "defaultcommandtimeout=180;pooling=True;minpoolsize=2;maxpoolsize=5;useaffectedro"& _ 
            "ws=False;allowuservariables=True")>  _
        Public Property dbConnectionLocalNetwork() As String
            Get
                Return CType(Me("dbConnectionLocalNetwork"),String)
            End Get
            Set
                Me("dbConnectionLocalNetwork") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("server=103.57.246.210;database=local_stock;port=3306;user id=rio;password=speech1"& _ 
            "23;defaultcommandtimeout=180;pooling=True;minpoolsize=2;maxpoolsize=5;useaffecte"& _ 
            "drows=False;allowuservariables=True")>  _
        Public Property dbConnectionRemote() As String
            Get
                Return CType(Me("dbConnectionRemote"),String)
            End Get
            Set
                Me("dbConnectionRemote") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("server=localhost;database=local_stock;port=3306;user id=rio;password=speech123;de"& _ 
            "faultcommandtimeout=180;pooling=True;minpoolsize=2;maxpoolsize=5;useaffectedrows"& _ 
            "=False;allowuservariables=True")>  _
        Public Property dbConnectionLocal() As String
            Get
                Return CType(Me("dbConnectionLocal"),String)
            End Get
            Set
                Me("dbConnectionLocal") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property Live() As Boolean
            Get
                Return CType(Me("Live"),Boolean)
            End Get
            Set
                Me("Live") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property Database() As Boolean
            Get
                Return CType(Me("Database"),Boolean)
            End Get
            Set
                Me("Database") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.Algo2Trade_Data_Tester.My.MySettings
            Get
                Return Global.Algo2Trade_Data_Tester.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
