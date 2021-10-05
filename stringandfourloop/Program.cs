using System;

namespace stringandfourloop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("siesta eesnimi");
            string firstname = Console.ReadLine();
           
            
            
            for (int i = 0; i < firstname.Length; i++)
            {
                Console.WriteLine(firstname[i]);
            }
        }
    }
}
