using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace XamarinForms_FormattedText_Issue
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Debug.WriteLine(sender.ToString());
            Debug.WriteLine(e.ToString());
        }
    }
}

