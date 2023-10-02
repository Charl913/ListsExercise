using ListsExercise.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListsExercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Airbnb : ContentPage
    {
        private ObservableCollection<Search> _search;
        ObservableCollection<Search> GetSearches() 
        {
            return _search = new ObservableCollection<Search>
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
        public Airbnb()
        {
            InitializeComponent();

            listView.ItemsSource = GetSearches();
        }

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var search = e.Item as Search;
            DisplayAlert("Tapped", search.Location, "OK");
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var search = (sender as MenuItem).CommandParameter as Search;
            _search.Remove(search);
        }

        private void listView_Refreshing(object sender, EventArgs e)
        {
            listView.ItemsSource = GetSearches();
            listView.EndRefresh();
        }
    }
}