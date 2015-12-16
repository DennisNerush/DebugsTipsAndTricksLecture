using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace DebugTipsAndTricks
{
    public class CheckInLab : IOptionalPlacesToLookAt
    {
        public Yossi IsYossiHere()
        {
            AskKindPerson();

            return null;
        }





















        private bool AskKindPerson()
        {
            throw new Exception("Not here");
        }
    }
}