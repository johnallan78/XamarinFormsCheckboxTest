using System;

using Xamarin.Forms;

namespace XamarinForms_CheckboxTest_Shared
{
    public class TestPage : ContentPage
    {
        public TestPage()
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

