﻿#pragma checksum "..\..\..\View\Principal.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BAA626ED431F3A32222E957A7CADB81D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3082
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AltzControls;
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


namespace SpokenBible.View {
    
    
    /// <summary>
    /// Principal
    /// </summary>
    public partial class Principal : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\View\Principal.xaml"
        internal AltzControls.AutoComplete busca;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\View\Principal.xaml"
        internal System.Windows.Controls.Button ler;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SpokenBible;component/view/principal.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\Principal.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.busca = ((AltzControls.AutoComplete)(target));
            
            #line 26 "..\..\..\View\Principal.xaml"
            this.busca.SearchRequest += new System.Windows.RoutedEventHandler(this.busca_SearchRequest);
            
            #line default
            #line hidden
            
            #line 26 "..\..\..\View\Principal.xaml"
            this.busca.TextChanged += new System.Windows.RoutedEventHandler(this.busca_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ler = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\View\Principal.xaml"
            this.ler.Click += new System.Windows.RoutedEventHandler(this.busca_SearchRequest);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}