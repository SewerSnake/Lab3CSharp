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

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            string classId = (sender as Button).ClassId;

            var input = this.FindByName<Entry>("inputText");

            switch (classId)
            {
                case "button1":
                    input.Text = "Knapp 1";
                    break;
                case "button2":
                    input.Text = "Knapp 2";
                    break;
                case "button3":
                    string outputText = $"Du skrev in {input.Text}";
                    input.Text = outputText;
                    break;
            }
        }
    }
}
