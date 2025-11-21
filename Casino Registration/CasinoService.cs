using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// F120859 - Жени Каракашева
namespace Casino_Registration
{
    public class CasinoService
    {
        private List<Player> players = new List<Player>();

        //adds a player to the list of casino players
        public void AddPlayer(Player p)
        {
            players.Add(p);
        }

        //gets a player by username
        public Player? FetchPlayer(string username)
        {
            return players.FirstOrDefault(x => x.Username == username);
        }

        //gets all players
        public List<Player> GetAllPlayers()
        {
            return players;
        }
    }
}
