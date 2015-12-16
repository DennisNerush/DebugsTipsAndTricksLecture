using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DebugTipsAndTricks
{
    public class FindYossiService
    {
        public bool IsYossiFound { get; private set; } = false;
        private IList<IOptionalPlacesToLookAt> _optionalPlacesToLookAts { get; }

        public FindYossiService()
        {
            _optionalPlacesToLookAts = new List<IOptionalPlacesToLookAt>
            {
                new CheckInKitchen(),
                new CheckInOfficeAlthoughHeIsDefinitelyNotThere(),
                new CheckInLab(),
                new CheckEverywhereElse(),
                new CheckInGameRoom(),

            };

        }
        public Yossi Find()
        {
            var map = IHaveTheMap();
            if (map == false)
                return null;

            FoundTheMap();

            foreach (var optionalPlaceToLookAt in _optionalPlacesToLookAts)
            {
                try
                {
                    var yossi = optionalPlaceToLookAt.IsYossiHere();
                    if (yossi != null)
                    {
                        IsYossiFound = true;
                        return yossi;
                    }
                }










                catch (Exception)
                {
                    // yam yam yam
                }
            }

            return null;
        }

        private static void FoundTheMap()
        {
            Console.WriteLine("Found the map!");
            Thread.Sleep(1000);
            Console.WriteLine("Now let's start looking");
            Thread.Sleep(2000);
        }

        private bool IHaveTheMap()
        {
            var mapFinder = new MapFinderService();
            mapFinder.Find();

            return mapFinder.Map != null;
        }
    }
}