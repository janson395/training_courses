﻿#pragma checksum "..\..\..\..\..\View\Pages\Profile\ProfilePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "76FC7DD7FB16A122BB25768BC441EFE3042913FE39FE8BC12423BFFD4B930FA6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using TraininCourse.View.Pages.Profile;


namespace TraininCourse.View.Pages.Profile {
    
    
    /// <summary>
    /// ProfilePage
    /// </summary>
    public partial class ProfilePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\..\..\View\Pages\Profile\ProfilePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TbUserName;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\..\View\Pages\Profile\ProfilePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TbUserRole;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\..\View\Pages\Profile\ProfilePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSetting;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\..\View\Pages\Profile\ProfilePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnStudying;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\..\View\Pages\Profile\ProfilePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnWillStudy;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\..\View\Pages\Profile\ProfilePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnStudied;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\..\View\Pages\Profile\ProfilePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox LbMyCoursesList;
        
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
            System.Uri resourceLocater = new System.Uri("/TraininCourse;component/view/pages/profile/profilepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\Pages\Profile\ProfilePage.xaml"
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
            this.TbUserName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.TbUserRole = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.BtnSetting = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\..\..\View\Pages\Profile\ProfilePage.xaml"
            this.BtnSetting.Click += new System.Windows.RoutedEventHandler(this.BtnSetting_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnStudying = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\..\..\View\Pages\Profile\ProfilePage.xaml"
            this.BtnStudying.Click += new System.Windows.RoutedEventHandler(this.BtnStudying_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnWillStudy = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\..\..\View\Pages\Profile\ProfilePage.xaml"
            this.BtnWillStudy.Click += new System.Windows.RoutedEventHandler(this.BtnWillStudy_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnStudied = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\..\..\View\Pages\Profile\ProfilePage.xaml"
            this.BtnStudied.Click += new System.Windows.RoutedEventHandler(this.BtnStudied_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.LbMyCoursesList = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
