﻿#pragma checksum "..\..\TemperatureWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6DA9B3589C3F325E362483FA6DD68A38EFE271C27C7C3ACC91C8A08AC74B9B34"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Laskin;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace Laskin {
    
    
    /// <summary>
    /// TemperatureWindow
    /// </summary>
    public partial class TemperatureWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\TemperatureWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Celcius;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\TemperatureWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InCelcius;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\TemperatureWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ConvertFromCelcius;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\TemperatureWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Fahrenheit;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\TemperatureWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InFahrenheit;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\TemperatureWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ConvertFromFahrenheit;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\TemperatureWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Kelvin;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\TemperatureWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InKelvin;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\TemperatureWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ConvertFromKelvin;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Laskin;component/temperaturewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TemperatureWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 33 "..\..\TemperatureWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuStandardClick);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 34 "..\..\TemperatureWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuScientificClick);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 35 "..\..\TemperatureWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuTemperatureClick);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 37 "..\..\TemperatureWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuExitClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Celcius = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.InCelcius = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.ConvertFromCelcius = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\TemperatureWindow.xaml"
            this.ConvertFromCelcius.Click += new System.Windows.RoutedEventHandler(this.btnFromCelcius_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Fahrenheit = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.InFahrenheit = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.ConvertFromFahrenheit = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\TemperatureWindow.xaml"
            this.ConvertFromFahrenheit.Click += new System.Windows.RoutedEventHandler(this.btnFromFahrenheit_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Kelvin = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.InKelvin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.ConvertFromKelvin = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\TemperatureWindow.xaml"
            this.ConvertFromKelvin.Click += new System.Windows.RoutedEventHandler(this.btnFromKelvin_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

