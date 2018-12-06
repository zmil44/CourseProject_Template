using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarcraftChess.Domain.Entitiy
{
    public class Leaderboard
    {
        public string Username { get; set; }
        public int Score { get; set; }
        public DateTime time { get; set; }
    }
}
