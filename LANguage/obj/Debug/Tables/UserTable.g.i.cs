// Updated by XamlIntelliSenseFileGenerator 22.03.2021 2:11:24
#pragma checksum "..\..\..\Tables\UserTable.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4DA3109CC19324F443CD81218E32757730B7E1087CA30F825C51A335145EF655"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using LANguage.Tables;
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


namespace LANguage.Tables
{


    /// <summary>
    /// UserTable
    /// </summary>
    public partial class UserTable : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 85 "..\..\..\Tables\UserTable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button createTupleButton;

#line default
#line hidden


#line 89 "..\..\..\Tables\UserTable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button changeTupleButton;

#line default
#line hidden


#line 93 "..\..\..\Tables\UserTable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteTupleButton;

#line default
#line hidden


#line 97 "..\..\..\Tables\UserTable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button openVisitsTableButton;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LANguage;component/tables/usertable.xaml", System.UriKind.Relative);

#line 1 "..\..\..\Tables\UserTable.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.listBoxTableClient = ((System.Windows.Controls.ListBox)(target));

#line 41 "..\..\..\Tables\UserTable.xaml"
                    this.listBoxTableClient.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listBoxTableClient_SelectionChanged);

#line default
#line hidden
                    return;
                case 2:
                    this.createTupleButton = ((System.Windows.Controls.Button)(target));

#line 85 "..\..\..\Tables\UserTable.xaml"
                    this.createTupleButton.Click += new System.Windows.RoutedEventHandler(this.createTupleButton_Click);

#line default
#line hidden
                    return;
                case 3:
                    this.changeTupleButton = ((System.Windows.Controls.Button)(target));

#line 89 "..\..\..\Tables\UserTable.xaml"
                    this.changeTupleButton.Click += new System.Windows.RoutedEventHandler(this.changeTupleButton_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.deleteTupleButton = ((System.Windows.Controls.Button)(target));

#line 93 "..\..\..\Tables\UserTable.xaml"
                    this.deleteTupleButton.Click += new System.Windows.RoutedEventHandler(this.deleteTupleButton_Click);

#line default
#line hidden
                    return;
                case 5:
                    this.openVisitsTableButton = ((System.Windows.Controls.Button)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.ListBox listBoxTableClient;
    }
}

