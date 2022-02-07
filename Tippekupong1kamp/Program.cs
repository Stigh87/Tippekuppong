using System;

namespace Tippekupong1kamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for denne kampen? ");
            //var bet = Console.ReadLine();
            //var homeGoals = 0;
            //var awayGoals = 0;
            //var matchIsRunning = true;
            //while (matchIsRunning)
            //{
            //    Console.Write("Kommandoer: \r\n - H = scoring hjemmelag\r\n - B = scoring bortelag\r\n - X = kampen er ferdig\r\nAngi kommando: ");
            //    var command = Console.ReadLine();
            //    matchIsRunning = command != "X";
            //    if (command == "H") homeGoals++;
            //    else if (command == "B") awayGoals++;
            //    Console.WriteLine($"Stillingen er {homeGoals}-{awayGoals}.");
            //}

            //var result = homeGoals == awayGoals ? "U" : homeGoals > awayGoals ? "H" : "B";
            //var isBetCorrect = bet.Contains(result);
            //var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
            //Console.WriteLine($"Du tippet {isBetCorrectText}");

            var match1 = new Match();
            match1.getBet();


        }
    }
}
