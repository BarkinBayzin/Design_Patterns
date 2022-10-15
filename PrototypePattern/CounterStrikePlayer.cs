using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    internal class CounterStrikePlayer
    {
        public CounterStrikePlayer(int playerId, string gameName, string gameType, bool isActive)
        {
            PlayerId = playerId;
            GameName = gameName;
            GameType = gameType;
            this.isActive = isActive;
        }

        public int PlayerId { get; set; }
        public string GameName { get; set; }
        public string GameType { get; set; }
        public bool isActive { get; set; }


    }
}
