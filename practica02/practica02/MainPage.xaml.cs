using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace practica02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            Item1.Clicked += async (sender, e) =>
            {
                //await Navigation.PushAsync(new PageStackLayout());

            };
            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new PageTabbedPage());
            };
            Item3.Clicked += async (sender, e) =>
            {
                //await Navigation.PushAsync(new PageGrid());

            };
            Item7.Clicked += async (sender, e) =>
            {
                //await Navigation.PushAsync(new PageHierchicalNav());

            };
            Item5.Clicked += async (sender, e) =>
            {
                //Call Popup
                //await Navigation.PushModalAsync(new PageFormulario());

            };

            Item6.Clicked += async (sender, e) =>
            {
                //Call Popup
                var answer = await DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
                Debug.WriteLine("Answer: " + answer);

            };
        }
    }
}
