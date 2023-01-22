using NbaApi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbaApi.ViewModels
{
    public class DisplayPlayersViewModel:BaseViewModel
    {
        private ObservableCollection<Player> players;

        public ObservableCollection<Player> Players
        {
            get { return players; }
            set { players= value; OnPropertyChanged(); }
        }


        public DisplayPlayersViewModel()
        {

        }

    }
}
