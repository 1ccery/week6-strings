using System;

namespace stringreversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //sisesta eesnimi, konsool kuvab nime tagurpidi
            Console.WriteLine("Sisesta oma eesimi");
            string firstname = Console.ReadLine();

            for(int i = firstname.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(firstname[i]);

            }



        }
    }
}
