﻿#pragma checksum "..\..\..\Pages\MyMuesliMixesPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "33505EC47CE14EB33BF54E5B15B6D660F5203965BD184ACFDD424659FF820D1C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PremiumJustMuesliApp.Pages;
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


namespace PremiumJustMuesliApp.Pages {
    
    
    /// <summary>
    /// MyMuesliMixesPage
    /// </summary>
    public partial class MyMuesliMixesPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\Pages\MyMuesliMixesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGMyMuesliMixes;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Pages\MyMuesliMixesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BBack;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Pages\MyMuesliMixesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BEdit;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Pages\MyMuesliMixesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BDelete;
        
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
            System.Uri resourceLocater = new System.Uri("/PremiumJustMuesliApp;component/pages/mymueslimixespage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\MyMuesliMixesPage.xaml"
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
            this.DGMyMuesliMixes = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.BBack = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Pages\MyMuesliMixesPage.xaml"
            this.BBack.Click += new System.Windows.RoutedEventHandler(this.BBack_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BEdit = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Pages\MyMuesliMixesPage.xaml"
            this.BEdit.Click += new System.Windows.RoutedEventHandler(this.BEdit_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BDelete = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Pages\MyMuesliMixesPage.xaml"
            this.BDelete.Click += new System.Windows.RoutedEventHandler(this.BDelete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
