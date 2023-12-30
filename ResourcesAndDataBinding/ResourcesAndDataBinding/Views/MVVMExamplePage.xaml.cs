﻿using ResourcesAndDataBinding.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ResourcesAndDataBinding.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MVVMExamplePage : ContentPage
    {
        private MagazineSampleViewModel ViewModel { get; set; }

        public MVVMExamplePage()
        {
            InitializeComponent();
            this.ViewModel = new MagazineSampleViewModel();
            this.BindingContext = this.ViewModel;

        }
    }
}