﻿#pragma checksum "..\..\..\DialogWindow\DialogWindowToClient.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EEB2FEDE6B9489A1E1351A204E5136CCDDCBC7E6E81CB849CB8FE2CC47DE6D2B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using LANguage.DialogWindow;
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


namespace LANguage.DialogWindow {
    
    
    /// <summary>
    /// DialogWindowToClient
    /// </summary>
    public partial class DialogWindowToClient : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\DialogWindow\DialogWindowToClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LANguage.DialogWindow.DialogWindowToClient thisWindow;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\DialogWindow\DialogWindowToClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid windowGrid;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\DialogWindow\DialogWindowToClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IdTextBlock;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\DialogWindow\DialogWindowToClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox genderBox;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\DialogWindow\DialogWindowToClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image photo;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\DialogWindow\DialogWindowToClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addButton;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\DialogWindow\DialogWindowToClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelButton;
        
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
            System.Uri resourceLocater = new System.Uri("/LANguage;component/dialogwindow/dialogwindowtoclient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DialogWindow\DialogWindowToClient.xaml"
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
            this.thisWindow = ((LANguage.DialogWindow.DialogWindowToClient)(target));
            
            #line 15 "..\..\..\DialogWindow\DialogWindowToClient.xaml"
            this.thisWindow.Activated += new System.EventHandler(this.Window_Activated);
            
            #line default
            #line hidden
            return;
            case 2:
            this.windowGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.IdTextBlock = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.genderBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.photo = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.addButton = ((System.Windows.Controls.Button)(target));
            
            #line 91 "..\..\..\DialogWindow\DialogWindowToClient.xaml"
            this.addButton.Click += new System.Windows.RoutedEventHandler(this.addButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cancelButton = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

