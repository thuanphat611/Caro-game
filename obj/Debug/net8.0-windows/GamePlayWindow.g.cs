﻿#pragma checksum "..\..\..\GamePlayWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14B95101BF167279DC2DF212210126628D02B8F4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Caro_game;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Caro_game {
    
    
    /// <summary>
    /// GamePlayWindow
    /// </summary>
    public partial class GamePlayWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\GamePlayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid TopSpace;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\GamePlayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border BoardBorder;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\GamePlayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Board;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\GamePlayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ControlBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Caro-game;component/gameplaywindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\GamePlayWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\GamePlayWindow.xaml"
            ((Caro_game.GamePlayWindow)(target)).SizeChanged += new System.Windows.SizeChangedEventHandler(this.Window_SizeChanged);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\GamePlayWindow.xaml"
            ((Caro_game.GamePlayWindow)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.Board_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TopSpace = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.BoardBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 4:
            this.Board = ((System.Windows.Controls.Canvas)(target));
            
            #line 18 "..\..\..\GamePlayWindow.xaml"
            this.Board.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Board_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ControlBtn = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\GamePlayWindow.xaml"
            this.ControlBtn.Click += new System.Windows.RoutedEventHandler(this.ControlBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

