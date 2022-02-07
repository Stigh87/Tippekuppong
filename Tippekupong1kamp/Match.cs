using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tippekupong1kamp
{
    internal class Match
    {
        int homeGoals;
        int awayGoals;
        bool matchIsRunning;
        string bet;
        string command;
        string result;

        public Match()
        {
          //Constructor:
            homeGoals = 0;
            awayGoals = 0;
            matchIsRunning = true;

        }

        public void getBet()
        {
            Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for denne kampen? ");
            bet = Console.ReadLine();
            goals();
        }
    
        public void goals()
        {
            while (matchIsRunning)
            {
                Console.Write("Kommandoer: \r\n - H = scoring hjemmelag\r\n - B = scoring bortelag\r\n - X = kampen er ferdig\r\nAngi kommando: ");
                command = Console.ReadLine();

                    if (command == "H") homeGoals++;
                    else if (command == "B") awayGoals++;
                    else if (command == "X")
                    {
                        matchIsRunning = false;
                        checkResult();
                    }
                    else Console.WriteLine("Ugyldig input");

                if (matchIsRunning) Console.WriteLine($"Stillingen er {homeGoals}-{awayGoals}.");
                if (!matchIsRunning) Console.WriteLine($"Stillingen ble {homeGoals}-{awayGoals}.");
            }
        }
        public void checkResult()
        {
            
            if (homeGoals > awayGoals) result = "H";
            else if (awayGoals > homeGoals) result = "B";
            else if (awayGoals == homeGoals) result = "U";
            checkBet();
        }
        private void checkBet()
        {
            if (bet == result) Console.WriteLine("Du tippet riktig!");
            else Console.WriteLine("Du tippet feil!");
        }

    }

}
