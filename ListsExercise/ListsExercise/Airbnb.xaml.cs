using ListsExercise.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListsExercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Airbnb : ContentPage
    {
        public Airbnb()
        {
            InitializeComponent();

            listView.ItemsSource = new List<Search> 
            {
                new Search
                {
                    Id = 1,
                    Location = "West Hollywood, CA, United States",
                    CheckIn = new DateTime(2016, 9, 1),
                    CheckOut = new DateTime(2016, 11, 1)
                },
                new Search
                {
                    Id = 2,
                    Location = "Santa Monica, CA, United States",
                    CheckIn = new DateTime(2016, 9, 1),
                    CheckOut = new DateTime(2016, 11, 1)
                }

            };
        }
    }
}