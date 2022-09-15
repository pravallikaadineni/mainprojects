using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace player_and_team
{
    public class player
    {
        private int _PlayeriD;
        public int PlayerID
        {
            get { return _PlayeriD; }
            set { _PlayeriD = value; }
        }

        private string _playername;

        public string PlayerName
        {
            get { return _playername; }
            set { _playername = value; }
        }
        private int _playerage;

        public int PlayerAge
        {
            get { return _playerage; }
            set { _playerage = value; }
        }
    }
}

