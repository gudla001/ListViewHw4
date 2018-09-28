using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ListViewHw
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ListViewCells());
        }
    }
}
