﻿#pragma checksum "..\..\UserPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "09AE11ADA3696578DA0C8F57C96975C517F6E44D68EE3000CD110A5138D60972"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ReBirth;
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


namespace ReBirth {
    
    
    /// <summary>
    /// UserPage
    /// </summary>
    public partial class UserPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 18 "..\..\UserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame frame;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\UserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView exerciseListView;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\UserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel pagesNav;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\UserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock goBack;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\UserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock prevPage;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\UserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock openedPage;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\UserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock nextPage;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\UserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock goForward;
        
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
            System.Uri resourceLocater = new System.Uri("/ReBirth;component/userpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UserPage.xaml"
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
            this.frame = ((System.Windows.Controls.Frame)(target));
            
            #line 18 "..\..\UserPage.xaml"
            this.frame.Navigated += new System.Windows.Navigation.NavigatedEventHandler(this.frame_Navigated);
            
            #line default
            #line hidden
            return;
            case 2:
            this.exerciseListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this.pagesNav = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.goBack = ((System.Windows.Controls.TextBlock)(target));
            
            #line 50 "..\..\UserPage.xaml"
            this.goBack.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.GoBack_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.prevPage = ((System.Windows.Controls.TextBlock)(target));
            
            #line 51 "..\..\UserPage.xaml"
            this.prevPage.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.GoBack_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.openedPage = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.nextPage = ((System.Windows.Controls.TextBlock)(target));
            
            #line 53 "..\..\UserPage.xaml"
            this.nextPage.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.GoForward_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.goForward = ((System.Windows.Controls.TextBlock)(target));
            
            #line 54 "..\..\UserPage.xaml"
            this.goForward.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.GoForward_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 3:
            
            #line 32 "..\..\UserPage.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.exerciseTypeName_MouseEnter);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

