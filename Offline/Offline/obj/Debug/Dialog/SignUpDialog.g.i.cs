﻿#pragma checksum "..\..\..\Dialog\SignUpDialog.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F800AE5773F7D79814902B24E010D5C7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace Offline.Dialog {
    
    
    /// <summary>
    /// SignUpDialog
    /// </summary>
    public partial class SignUpDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 86 "..\..\..\Dialog\SignUpDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ID;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\Dialog\SignUpDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextPassword;
        
        #line default
        #line hidden
        
        
        #line 178 "..\..\..\Dialog\SignUpDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextPasswordConfirm;
        
        #line default
        #line hidden
        
        
        #line 224 "..\..\..\Dialog\SignUpDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextUserName;
        
        #line default
        #line hidden
        
        
        #line 297 "..\..\..\Dialog\SignUpDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SignUp;
        
        #line default
        #line hidden
        
        
        #line 298 "..\..\..\Dialog\SignUpDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cancle;
        
        #line default
        #line hidden
        
        
        #line 299 "..\..\..\Dialog\SignUpDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.ProgressRing loading;
        
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
            System.Uri resourceLocater = new System.Uri("/Offline;component/dialog/signupdialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Dialog\SignUpDialog.xaml"
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
            this.ID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TextPassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TextPasswordConfirm = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TextUserName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.SignUp = ((System.Windows.Controls.Button)(target));
            
            #line 297 "..\..\..\Dialog\SignUpDialog.xaml"
            this.SignUp.Click += new System.Windows.RoutedEventHandler(this.SignUp_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Cancle = ((System.Windows.Controls.Button)(target));
            
            #line 298 "..\..\..\Dialog\SignUpDialog.xaml"
            this.Cancle.Click += new System.Windows.RoutedEventHandler(this.Cancle_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.loading = ((MahApps.Metro.Controls.ProgressRing)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
