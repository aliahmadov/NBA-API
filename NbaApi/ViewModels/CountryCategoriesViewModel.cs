using NbaApi.Commands;
using NbaApi.Models;
using NbaApi.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbaApi.ViewModels
{
    public class CountryCategoriesViewModel:BaseViewModel
    {
        private ObservableCollection<CountryCategory> countryCategories;

        public ObservableCollection<CountryCategory> CountryCategories
        {
            get { return countryCategories; }
            set { countryCategories = value; OnPropertyChanged(); }
        }


        private ObservableCollection<Player> players;

        public ObservableCollection<Player> TeamPlayers
        {
            get { return players; }
            set { players = value;OnPropertyChanged(); }
        }

        public RelayCommand SelectedCountryCommand { get; set; }

        public CountryCategory SelectedCountry { get; set; }
        public CountryCategoriesViewModel()
        {

            SelectedCountryCommand = new RelayCommand(c =>
            {

                var view = new DisplayPlayers();
                var viewModel = new DisplayPlayersViewModel();
                view.DataContext=viewModel;

                viewModel.Players = new ObservableCollection<Player>(TeamPlayers.Where(p => p.birth.country == SelectedCountry.Name));

                view.ShowDialog();


            });
        }
    }
}
