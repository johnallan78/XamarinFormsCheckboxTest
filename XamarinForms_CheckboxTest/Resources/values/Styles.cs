using System;

using Xamarin.Forms;

namespace XamarinForms_CheckboxTest.Resources.values
{
    public class Styles : ContentPage
    {
        public Styles()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

