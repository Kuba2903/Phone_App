﻿#pragma checksum "..\..\..\..\Views\WebBrowserView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F2D025ABD57A1C6F9CA8E6EC3C2BE331F5C77D16"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Phone_App.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Phone_App.Views {
    
    
    /// <summary>
    /// WebBrowserView
    /// </summary>
    public partial class WebBrowserView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\..\Views\WebBrowserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UrlTxt;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Views\WebBrowserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WebBrowser wb;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Phone_App;component/views/webbrowserview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\WebBrowserView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 26 "..\..\..\..\Views\WebBrowserView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Back);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 27 "..\..\..\..\Views\WebBrowserView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Next);
            
            #line default
            #line hidden
            return;
            case 3:
            this.UrlTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            
            #line 39 "..\..\..\..\Views\WebBrowserView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Go);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 40 "..\..\..\..\Views\WebBrowserView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Refresh);
            
            #line default
            #line hidden
            return;
            case 6:
            this.wb = ((System.Windows.Controls.WebBrowser)(target));
            
            #line 48 "..\..\..\..\Views\WebBrowserView.xaml"
            this.wb.Navigating += new System.Windows.Navigation.NavigatingCancelEventHandler(this.WebBrowser_Navigating);
            
            #line default
            #line hidden
            
            #line 48 "..\..\..\..\Views\WebBrowserView.xaml"
            this.wb.Navigated += new System.Windows.Navigation.NavigatedEventHandler(this.WebBrowser_Navigated);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

