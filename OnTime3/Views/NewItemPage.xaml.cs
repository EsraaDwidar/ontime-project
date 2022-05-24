using System;
using System.Collections.Generic;
using System.ComponentModel;
using OnTime3.Models;
using OnTime3.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OnTime3.Views
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