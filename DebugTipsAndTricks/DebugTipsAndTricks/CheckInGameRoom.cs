using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ThridParty;

namespace DebugTipsAndTricks
{
    public class CheckInGameRoom : IOptionalPlacesToLookAt
    {
        public Yossi IsYossiHere()
        {
            var gameRoom = new GamesRoom();
            if (gameRoom.IsLocked())
            {
                gameRoom.TryOpenWithKey("");// That could be the key???

                // PD what? (PDB)
                if (gameRoom.IsLocked() == false)
                {
                    var yossi = new Yossi();
                    return yossi;
                }
            }

            return null;
        }
    }
}