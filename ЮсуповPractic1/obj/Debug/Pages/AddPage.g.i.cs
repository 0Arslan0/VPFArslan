﻿#pragma checksum "..\..\..\Pages\AddPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DEA94D2D1CC48D50C6078F984C6CDD0645BDF0403DC13C665F1E15E443E2FE7A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using ЮсуповPractic1.Pages;


namespace ЮсуповPractic1.Pages {
    
    
    /// <summary>
    /// AddPage
    /// </summary>
    public partial class AddPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Pages\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBName;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBMaterial;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Pages\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBType;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Pages\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBStyle;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Pages\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBQuantity_in_stock;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Pages\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BAdd;
        
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
            System.Uri resourceLocater = new System.Uri("/ЮсуповPractic1;component/pages/addpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AddPage.xaml"
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
            this.TBName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TBMaterial = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TBType = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TBStyle = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TBQuantity_in_stock = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.BAdd = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\Pages\AddPage.xaml"
            this.BAdd.Click += new System.Windows.RoutedEventHandler(this.BAdd_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

