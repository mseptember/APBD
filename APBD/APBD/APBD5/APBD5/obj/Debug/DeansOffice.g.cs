﻿#pragma checksum "..\..\DeansOffice.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79125483166F8A065475F521CE9D3317F1640F65"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using APBD5;
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


namespace APBD5 {
    
    
    /// <summary>
    /// DeansOffice
    /// </summary>
    public partial class DeansOffice : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\DeansOffice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TitleLabel;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\DeansOffice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NazwiskoTextBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\DeansOffice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ImieTextBox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\DeansOffice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NrIndeksuTextBox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\DeansOffice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox StudiaComboBox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\DeansOffice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox PrzedmiotyListBox;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\DeansOffice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ConfirmButton;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\DeansOffice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveButton;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\DeansOffice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CheckButton;
        
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
            System.Uri resourceLocater = new System.Uri("/APBD5;component/deansoffice.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DeansOffice.xaml"
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
            this.TitleLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.NazwiskoTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ImieTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.NrIndeksuTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.StudiaComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.PrzedmiotyListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.ConfirmButton = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\DeansOffice.xaml"
            this.ConfirmButton.Click += new System.Windows.RoutedEventHandler(this.ConfirmButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.RemoveButton = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\DeansOffice.xaml"
            this.RemoveButton.Click += new System.Windows.RoutedEventHandler(this.RemoveButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.CheckButton = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\DeansOffice.xaml"
            this.CheckButton.Click += new System.Windows.RoutedEventHandler(this.CheckButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

