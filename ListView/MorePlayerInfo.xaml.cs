using System;
using System.Collections.Generic;
using ListViewHw.Models;
using Xamarin.Forms;

namespace ListViewHw
{
    public partial class MorePlayerInfo : ContentPage
    {
        public MorePlayerInfo()
        {
            InitializeComponent();
        }
        public MorePlayerInfo(People people)
        {
            InitializeComponent();
            BindingContext = people;
        }
    }
}
