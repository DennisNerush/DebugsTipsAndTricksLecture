using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace DebugTipsAndTricks
{
    internal class MapFinderService
    {
        private List<string> _allEmployees;
        public Map Map { get; private set; }

        public Map Find()
        {
            return LookInLotsOfDifferentPlaces();
        }




















       
















        private Map LookInLotsOfDifferentPlaces()
        {
            LookOnTheTable();
            LookUnderTheTable();
            LookInTheCloset();
            CloseTheCloset();
            LookInMyBag();
            if (!AskEmployees()) return null;
            AskMyMother();
            LookInTheRefrigerator();
            LookInTheCoffeeMachine();
            LookInNocRoom();
            LookInRoom1();
            LookInRoom2();
            LookInRoom3();
            LookInRoom4();
            LookInRoom5();
            UseThePhoneAndAskSomeoneWhoKnows();
            return Map;
        }


        private void LookInRoom5()
        {
            // Lot's off nasty, ugly and legacy code that makes your headache 
        }

        private void LookInRoom4()
        {
            // Lot's off nasty, ugly and legacy code that makes your headache 
        }

        private void LookInRoom3()
        {

            // Lot's off nasty, ugly and legacy code that makes your headache 
        }

        private bool AskEmployees()
        {
            try
            {
                File.ReadAllText("phonebook.txt");

                foreach (var employee in _allEmployees)
                {
                    // Mmm I wonder what is the output of this line
                    var hasAClue = HasAClue(employee);
                    if (hasAClue)
                    {
                        // And this
                        var wasItUsefull = TellsYouSomethingMeaningfull();
                    }
                }
            }
























            catch (Exception)
            {
                // Never ever swallow exceptions!!!!
                Console.WriteLine("houston, we got a problem");
                return false;
            }

            return true;
        }





































        private bool TellsYouSomethingMeaningfull()
        {
            return false;
        }


        private bool HasAClue(string employee)
        {
            if (employee.Contains("45") || employee.Contains("31") || employee.Contains("99"))
            {
                return true;
            }

            return false;
        }

        private void LookInRoom2()
        {
            // Lot's off nasty, ugly and legacy code that makes your headache 
        }

        private void LookInRoom1()
        {
            // Lot's off nasty, ugly and legacy code that makes your headache 
        }

        private void LookInRoom()
        {
            // Lot's off nasty, ugly and legacy code that makes your headache 
        }

        private void LookInNocRoom()
        {
            // Lot's off nasty, ugly and legacy code that makes your headache 
        }

        private void LookInTheCoffeeMachine()
        {
            // Lot's off nasty, ugly and legacy code that makes your headache 
        }

        private void LookInTheRefrigerator()
        {
            // Lot's off nasty, ugly and legacy code that makes your headache 
        }

        private void AskMyMother()
        {
            // Lot's off nasty, ugly and legacy code that makes your headache 
        }

        private void LookInMyBag()
        {
            // Lot's off nasty, ugly and legacy code that makes your headache 
        }

        private void CloseTheCloset()
        {
            // Lot's off nasty, ugly and legacy code that makes your headache 
        }

        private void LookInTheCloset()
        {
            // Lot's off nasty, ugly and legacy code that makes your headache 
        }

        private void LookUnderTheTable()
        {
            // Lot's off nasty, ugly and legacy code that makes your headache 
        }

        private void LookOnTheTable()
        {
            // Lot's off nasty, ugly and legacy code that makes your headache 
        }


        private void UseThePhoneAndAskSomeoneWhoKnows()
        {
                                                                                                                                                                                                                                            if (File.Exists("pass.txt"))
                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                Map =new Map();
                                                                                                                                                                                                                                                return;
                                                                                                                                                                                                                                            }
           
            var pleaseHelp = Process.Start("TheOneWhoGotTheMap.exe");
            pleaseHelp.WaitForExit();

            if (pleaseHelp.ExitCode == 1)
            {
                Map = new Map();
                                                                                                                                                                                                                                           File.WriteAllText("pass.txt", "you can go");
            }
        }






























        public MapFinderService()
        {
            _allEmployees = new List<string>();
            for (int i = 0; i < 100; i++)
            {
                _allEmployees.Add($"employee #{i + 1}");
            }
        }
    }
}