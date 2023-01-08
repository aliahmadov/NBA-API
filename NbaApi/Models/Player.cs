using NbaApi.ApiEntities;
using NbaApi.Services.NBAApiService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbaApi.Models
{
    public class Player
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public Birth birth { get; set; }
        public Nba nba { get; set; }
        public Height height { get; set; }
        public Weight weight { get; set; }
        public string college { get; set; }
        public string affiliation { get; set; }
        public Leagues leagues { get; set; }
    }
}
