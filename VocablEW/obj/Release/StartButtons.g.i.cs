﻿#pragma checksum "..\..\StartButtons.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F9DD0FBAAE79002907FC7FC3F41E043E"
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
    /// StartButtons
    /// </summary>
    public partial class StartButtons : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\StartButtons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse btnCheck;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\StartButtons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse btnStudy;
        
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
            System.Uri resourceLocater = new System.Uri("/VocablEW;component/startbuttons.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\StartButtons.xaml"
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
            
            #line 9 "..\..\StartButtons.xaml"
            ((VocablEW.StartButtons)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnCheck = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 15 "..\..\StartButtons.xaml"
            this.btnCheck.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.btnCheck_MouseLeftButtonUp);
            
            #line default
            #line hidden
            
            #line 15 "..\..\StartButtons.xaml"
            this.btnCheck.MouseEnter += new System.Windows.Input.MouseEventHandler(this.btn_MouseEnter);
            
            #line default
            #line hidden
            
            #line 15 "..\..\StartButtons.xaml"
            this.btnCheck.MouseLeave += new System.Windows.Input.MouseEventHandler(this.btn_MouseLeave);
            
            #line default
            #line hidden
            
            #line 16 "..\..\StartButtons.xaml"
            this.btnCheck.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btn_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnStudy = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 25 "..\..\StartButtons.xaml"
            this.btnStudy.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.btnStudy_MouseLeftButtonUp);
            
            #line default
            #line hidden
            
            #line 25 "..\..\StartButtons.xaml"
            this.btnStudy.MouseEnter += new System.Windows.Input.MouseEventHandler(this.btn_MouseEnter);
            
            #line default
            #line hidden
            
            #line 25 "..\..\StartButtons.xaml"
            this.btnStudy.MouseLeave += new System.Windows.Input.MouseEventHandler(this.btn_MouseLeave);
            
            #line default
            #line hidden
            
            #line 26 "..\..\StartButtons.xaml"
            this.btnStudy.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btn_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
