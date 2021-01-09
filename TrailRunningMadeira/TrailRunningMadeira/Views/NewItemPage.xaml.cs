using System;
using System.Collections.Generic;
using System.ComponentModel;
using TrailRunningMadeira.Models;
using TrailRunningMadeira.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrailRunningMadeira.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}