using System;

namespace Uppgift_2._12
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej Ahmed, för att du ska kunna hyra bil nehöver jag veta hur många dagar du vill hyra den och sen ungefär hur många kilometer kör du?");
            Console.WriteLine("Jag behöver hyra den i två dagar och kommer köra ungefär tio kilometer per dag");
            int dagtotal = 1000;
            int kilometerpris = 20;
            int start = 300;
            int allt = dagtotal + kilometerpris + start;
            Console.WriteLine("Då kommer allt kosta " + allt);
        }
    }
}