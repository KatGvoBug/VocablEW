﻿#pragma checksum "..\..\windowOfAdding.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A8D5CE95C06EDE49D40244DB2506BA34"
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
using VocablEW;


namespace VocablEW {
    
    
    /// <summary>
    /// WindowOfAdding
    /// </summary>
    public partial class WindowOfAdding : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\windowOfAdding.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\windowOfAdding.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox engWord;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\windowOfAdding.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox rusWord;
        
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
            System.Uri resourceLocater = new System.Uri("/VocablEW;component/windowofadding.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\windowOfAdding.xaml"
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
            
            #line 8 "..\..\windowOfAdding.xaml"
            ((VocablEW.WindowOfAdding)(target)).LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.Window_LostKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\windowOfAdding.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.btnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.engWord = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\windowOfAdding.xaml"
            this.engWord.GotFocus += new System.Windows.RoutedEventHandler(this.engWord_GotFocus);
            
            #line default
            #line hidden
            
            #line 36 "..\..\windowOfAdding.xaml"
            this.engWord.LostFocus += new System.Windows.RoutedEventHandler(this.engWord_LostFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.rusWord = ((System.Windows.Controls.TextBox)(target));
            
            #line 38 "..\..\windowOfAdding.xaml"
            this.rusWord.GotFocus += new System.Windows.RoutedEventHandler(this.rusWord_GotFocus);
            
            #line default
            #line hidden
            
            #line 38 "..\..\windowOfAdding.xaml"
            this.rusWord.LostFocus += new System.Windows.RoutedEventHandler(this.rusWord_LostFocus);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

