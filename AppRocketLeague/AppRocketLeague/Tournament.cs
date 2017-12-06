using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRocketLeague
{
    class Tournament
    {
        List<Competitor> contestants;
        DateTime eventDate;
        string location;

        Tournament()
        {
            
        }

        Tournament(List<Competitor> _contestants, DateTime _eventDate, string _location)
        {
            contestants = _contestants;
            eventDate = _eventDate;
            location = _location;
        }


    }
}
