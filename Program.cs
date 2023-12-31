﻿namespace KlikkerSpill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new ClickerGame();
            var commands = new Commands(game);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Kommandoer:\r\n" +
                                  "- SPACE = klikk(og få poeng)\r\n" +
                                  "- K = kjøp oppgradering \r\n" +
                                  "øker poeng per klikk koster 10 poeng\r\n" +
                                  "- S = kjøp superoppgradering øker \"poeng per klikk\" for den vanlige oppgraderingen. koster 100 poeng\r\n" +
                                  "- X = avslutt applikasjonen");
                Console.WriteLine($"Du har {game.Points} poeng.");
                Console.WriteLine("Trykk tast for ønsket kommando.");
                var keyInfo = Console.ReadKey();
                var command = char.ToUpper(keyInfo.KeyChar);
                commands.Run(command);
            }
        }
    }
}
