﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamairnAppCenter.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamairnAppCenter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
            WV.Source = "http://www.geenraltesting.somee.com/api/Report/GetReport?ReportName=UserDetails";
        }
    }
}