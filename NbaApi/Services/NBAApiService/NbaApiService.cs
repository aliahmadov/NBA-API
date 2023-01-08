using NbaApi.ApiEntities;
using NbaApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NbaApi.Services.NBAApiService
{



    public class NbaApiService
    {
        public async Task<List<Player>> GetPlayersByTeamIdAsync(int teamId)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://api-nba-v1.p.rapidapi.com/players?team={teamId}&season=2021"),
                Headers =
    {
        { "X-RapidAPI-Key", ApiKeys.Key },
        { "X-RapidAPI-Host", "api-nba-v1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<Rootobject>(body);
                var players = data.response.ToList();
                var result = from r in players
                             select new Player
                             {
                                 id = r.id,
                                 firstname = r.firstname,
                                 affiliation = r.affiliation,
                                 birth = r.birth,
                                 college = r.college,
                                 height = r.height,
                                 lastname = r.lastname,
                                 leagues = r.leagues,
                                 nba = r.nba,
                                 weight = r.weight
                             };
                return result.ToList();
            }
        }
        public async Task<List<ApiEntities.Teams.Response>> GetTeamsAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://api-nba-v1.p.rapidapi.com/teams"),
                Headers =
    {
        { "X-RapidAPI-Key", ApiKeys.Key },
        { "X-RapidAPI-Host", "api-nba-v1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<ApiEntities.Teams.Rootobject>(body);
                var teams = data.response.ToList();

                return teams;
            }

        }

    }
}

