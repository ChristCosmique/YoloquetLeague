using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRocketLeague
{
    class Competitor
    {
        string name;
        int rank; // int?
        // Voir comment on défini un participant

        Competitor()
        {

        }

        Competitor(string _name, int _rank)
        {
            name = _name;
            rank = _rank;
        }
    }
}
