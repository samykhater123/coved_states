using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coved_states.oppenweathermodelapp
{
    public class sys
    {
        
            public int type { get; set; }
            public int id { get; set; }
            public string country { get; set; }
            public int sunrise { get; set; }
            public int sunset { get; set; }
            public int timezone { get; set; }
            public int IDZ { get; set; }
            public string name { get; set; }
            public int cod { get; set; }
    }
}
