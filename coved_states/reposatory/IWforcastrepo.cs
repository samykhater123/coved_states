using coved_states.oppenweathermodelapp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coved_states.reposatory
{
    interface IWforcastrepo
    {
        weatherresponse getforcast(string city);
    }
}
