﻿#pragma checksum "..\..\newProjectWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49F223F462F07028979636C30D03E8AA0A2910DA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Phosh;
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace Phosh {
    
    
    /// <summary>
    /// newProjectWindow
    /// </summary>
    public partial class newProjectWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\newProjectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid mainGrid;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\newProjectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ProjectTitle;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\newProjectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ProjectName;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\newProjectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid boxGrid;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\newProjectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label newWidthLabel;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\newProjectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label newHeightLabel;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\newProjectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox WidthDoc;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\newProjectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HeightDoc;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\newProjectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AccessButton;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\newProjectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.ColorPicker ColorPicker;
        
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
            System.Uri resourceLocater = new System.Uri("/Phosh;component/newprojectwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\newProjectWindow.xaml"
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
            
            #line 9 "..\..\newProjectWindow.xaml"
            ((Phosh.newProjectWindow)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.mainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.ProjectTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.ProjectName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.boxGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.newWidthLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.newHeightLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.WidthDoc = ((System.Windows.Controls.TextBox)(target));
            
            #line 44 "..\..\newProjectWindow.xaml"
            this.WidthDoc.KeyDown += new System.Windows.Input.KeyEventHandler(this.InputSize);
            
            #line default
            #line hidden
            return;
            case 9:
            this.HeightDoc = ((System.Windows.Controls.TextBox)(target));
            
            #line 45 "..\..\newProjectWindow.xaml"
            this.HeightDoc.KeyDown += new System.Windows.Input.KeyEventHandler(this.InputSize);
            
            #line default
            #line hidden
            return;
            case 10:
            this.AccessButton = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\newProjectWindow.xaml"
            this.AccessButton.Click += new System.Windows.RoutedEventHandler(this.AccessButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ColorPicker = ((Xceed.Wpf.Toolkit.ColorPicker)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

