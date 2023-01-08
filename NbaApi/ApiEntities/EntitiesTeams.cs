using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbaApi.ApiEntities.Teams
{


    public class Rootobject
    {
        public string get { get; set; }
        public object[] parameters { get; set; }
        public object[] errors { get; set; }
        public int results { get; set; }
        public Response[] response { get; set; }
    }

    public class Response
    {
        public int id { get; set; }
        public string name { get; set; }
        public string nickname { get; set; }
        public string code { get; set; }
        public string city { get; set; }
        public string logo { get; set; }
        public bool allStar { get; set; }
        public bool nbaFranchise { get; set; }
        public Leagues leagues { get; set; }
    }

    public class Leagues
    {
        public Standard standard { get; set; }
        public Vegas vegas { get; set; }
        public Utah utah { get; set; }
        public Sacramento sacramento { get; set; }
        public Africa africa { get; set; }
    }

    public class Standard
    {
        public string conference { get; set; }
        public string division { get; set; }
    }

    public class Vegas
    {
        public string conference { get; set; }
        public string division { get; set; }
    }

    public class Utah
    {
        public string conference { get; set; }
        public string division { get; set; }
    }

    public class Sacramento
    {
        public string conference { get; set; }
        public string division { get; set; }
    }

    public class Africa
    {
        public object conference { get; set; }
        public object division { get; set; }
    }


}
