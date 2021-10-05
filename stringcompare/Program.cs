using System;

namespace stringcompare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta enda eesnimi");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Siesesta oma perekonna nimi");
            string perekonna = Console.ReadLine();
            if(eesnimi.Length > perekonna.Length)
            {
                Console.WriteLine("eesnimi on pikem kui perekonna nimi");

            }
            else if(eesnimi.Length < perekonna.Length)
            {
                Console.WriteLine("perekonna nimi pikem kui eesnimi");
            }


            else(eesnimi.Length = perekonna.Length)
            {
                Console.WriteLine("molemad sama pikad");
            }

            
        }

    }
}
