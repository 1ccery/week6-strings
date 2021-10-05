using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert your name");
            string username = Console.ReadLine();
               // Console.WriteLine($"Tere {username}");
            //Console.WriteLine(username [0]);
            int usernamelenght = username.Length;
            
            Console.WriteLine($"Teie nimi on {usernamelenght} tähte pikk ");

            Console.WriteLine(username[usernamelenght-1]);


        }
        
        
    }
}
