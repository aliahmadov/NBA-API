using NbaApi.ApiEntities.Teams;
using NbaApi.Models;
using NbaApi.Services;
using NbaApi.Services.NBAApiService;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbaApi.ViewModels
{
    public class HomeViewModel:BaseViewModel
    {

		private ObservableCollection<Response> allTeams;

		public ObservableCollection<Response> AllTeams
        {
			get { return allTeams; }
			set { allTeams = value; OnPropertyChanged(); }
		}

		public HomeViewModel()
		{
			LoadData();
        }

		public async void LoadData()
		{
			var service = new NbaApiService();
			if (File.Exists("players.json"))
			{
				//var result = JsonHelper<Player>.Deserialize("players.json");
    //            AllPlayers = new ObservableCollection<Response>(result);
            }
			else
			{
                //var result = await service.GetPlayersByTeamIdAsync(1);
				//JsonHelper<Player>.Serialize(result, "players.json");
                //AllPlayers = new ObservableCollection<Response>(result);
			}

            if (File.Exists("teams.json"))
            {
                var result = JsonHelper<Response>.Deserialize("teams.json");
                AllTeams = new ObservableCollection<Response>(result.Skip(0).Take(10));
            }
            else
            {
                var result = await service.GetTeamsAsync();
                JsonHelper<Response>.Serialize(result, "teams.json");
                AllTeams = new ObservableCollection<Response>(result);
            }
            //var result = await service.GetTeamsAsync();
            //AllTeams = new ObservableCollection<Response>(result);
        }

	}
}
