﻿

#pragma checksum "C:\Users\Sumeet\Mu\Mu_genotype1\Mu_genotype1\Tweet.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5985A31C0D5B3A96F8D30FEDB3A4EB2E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;

namespace Mu_genotype1
{
    public partial class Tweet : Mu_genotype1.Common.LayoutAwarePage, IComponentConnector
    {
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 102 "..\..\..\Tweet.xaml"
                ((Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.ItemListView_SelectionChanged;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 53 "..\..\..\Tweet.xaml"
                ((Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.TweetIt_Click_1;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 72 "..\..\..\Tweet.xaml"
                ((Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.ItemListView_SelectionChanged;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 64 "..\..\..\Tweet.xaml"
                ((Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.VerifyPinBtn_Click_1;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 40 "..\..\..\Tweet.xaml"
                ((Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.GoBack;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 317 "..\..\..\Tweet.xaml"
                ((Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.TwitterConnectBtn_Click_1;
                 #line default
                 #line hidden
                break;
            case 7:
                #line 319 "..\..\..\Tweet.xaml"
                ((Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.RefreshButton_Click_1;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


