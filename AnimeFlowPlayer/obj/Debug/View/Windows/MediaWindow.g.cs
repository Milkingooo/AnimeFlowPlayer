﻿#pragma checksum "..\..\..\..\View\Windows\MediaWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BD3B0C9D79E6C80EC0BBDAE5E5AC55BC51E4671983CF8F71428C0BE1CFE4C3A5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AnimeFlowPlayer.View.Windows;
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


namespace AnimeFlowPlayer.View.Windows {
    
    
    /// <summary>
    /// MediaWindow
    /// </summary>
    public partial class MediaWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\..\..\View\Windows\MediaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backButton;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\View\Windows\MediaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement mediaElement;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\View\Windows\MediaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slider2;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\View\Windows\MediaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel controlPanel;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\View\Windows\MediaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPlay;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\View\Windows\MediaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPause;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\View\Windows\MediaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStop;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\View\Windows\MediaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button fullscreenButton;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\..\View\Windows\MediaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slider1;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\..\View\Windows\MediaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock time;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\View\Windows\MediaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView seriesCatalog;
        
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
            System.Uri resourceLocater = new System.Uri("/AnimeFlowPlayer;component/view/windows/mediawindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Windows\MediaWindow.xaml"
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
            
            #line 11 "..\..\..\..\View\Windows\MediaWindow.xaml"
            ((AnimeFlowPlayer.View.Windows.MediaWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.backButton = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\..\View\Windows\MediaWindow.xaml"
            this.backButton.Click += new System.Windows.RoutedEventHandler(this.backButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.mediaElement = ((System.Windows.Controls.MediaElement)(target));
            
            #line 60 "..\..\..\..\View\Windows\MediaWindow.xaml"
            this.mediaElement.MediaOpened += new System.Windows.RoutedEventHandler(this.mediaElement_MediaOpened);
            
            #line default
            #line hidden
            return;
            case 4:
            this.slider2 = ((System.Windows.Controls.Slider)(target));
            
            #line 62 "..\..\..\..\View\Windows\MediaWindow.xaml"
            this.slider2.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.slider2_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.controlPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.btnPlay = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\..\View\Windows\MediaWindow.xaml"
            this.btnPlay.Click += new System.Windows.RoutedEventHandler(this.btnPlay_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnPause = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\..\View\Windows\MediaWindow.xaml"
            this.btnPause.Click += new System.Windows.RoutedEventHandler(this.btnPause_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnStop = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\..\View\Windows\MediaWindow.xaml"
            this.btnStop.Click += new System.Windows.RoutedEventHandler(this.btnStop_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.fullscreenButton = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\..\..\View\Windows\MediaWindow.xaml"
            this.fullscreenButton.Click += new System.Windows.RoutedEventHandler(this.fullscreenButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.slider1 = ((System.Windows.Controls.Slider)(target));
            
            #line 91 "..\..\..\..\View\Windows\MediaWindow.xaml"
            this.slider1.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.slider1_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.time = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.seriesCatalog = ((System.Windows.Controls.ListView)(target));
            
            #line 103 "..\..\..\..\View\Windows\MediaWindow.xaml"
            this.seriesCatalog.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.seriesCatalog_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

