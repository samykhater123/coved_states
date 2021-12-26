using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coved_states.oppenweathermodelapp
{
    public class weatherresponse
    {
        public coord coord { get; set; }
        public List<weather>weather { get; set; }

        public string pase { get; set; }
        public main main { get; set; }

        public int visapility { get; set; }
        public wind wind { get; set; }
        public cluodes cloud { get; set; }
        public int dt { get; set; }
        public sys sys { get; set; }
        public int timezone { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
    }
}
