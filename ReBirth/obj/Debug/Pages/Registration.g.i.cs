﻿#pragma checksum "..\..\..\Pages\Registration.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "20197971CAE73F25E4DF55ACB67C7D291062BA98A4B7052FC0B2FCB44324BF2F"
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
    /// Registration
    /// </summary>
    public partial class Registration : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\Pages\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox Input;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Pages\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserNumberPhone;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Password;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Pages\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame frame;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Pages\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox InputNewUser;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Pages\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameBox;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Pages\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox surNameBox;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Pages\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PatronymicBox;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Pages\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TelephoneBox;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Pages\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PasswordBox;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Pages\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox sections;
        
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
            System.Uri resourceLocater = new System.Uri("/ReBirth;component/pages/registration.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Registration.xaml"
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
            this.Input = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 2:
            this.UserNumberPhone = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\Pages\Registration.xaml"
            this.UserNumberPhone.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Telephone_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Password = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            
            #line 31 "..\..\..\Pages\Registration.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LogIn_button);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 35 "..\..\..\Pages\Registration.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.WindowRegistration);
            
            #line default
            #line hidden
            return;
            case 6:
            this.frame = ((System.Windows.Controls.Frame)(target));
            
            #line 38 "..\..\..\Pages\Registration.xaml"
            this.frame.Navigated += new System.Windows.Navigation.NavigatedEventHandler(this.frame_Navigated);
            
            #line default
            #line hidden
            return;
            case 7:
            this.InputNewUser = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 8:
            this.NameBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.surNameBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.PatronymicBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.TelephoneBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 57 "..\..\..\Pages\Registration.xaml"
            this.TelephoneBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Telephone_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 12:
            this.PasswordBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.sections = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 14:
            
            #line 75 "..\..\..\Pages\Registration.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GetRegistr);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
