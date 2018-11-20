using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Lab3
{
    public partial class ButtonsPage : ContentPage
    {
        public ButtonsPage()
        {
            InitializeComponent();
        }

        void ButtonOne_Pressed(object sender, System.EventArgs e)
        {
            Console.WriteLine("1");
        }

        void ButtonTwo_Pressed(object sender, System.EventArgs e)
        {
            Console.WriteLine("2");
        }

        void ButtonThree_Pressed(object sender, System.EventArgs e)
        {
            Console.WriteLine("3");
        }
    }
}
