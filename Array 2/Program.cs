using System;
namespace arrat_2
{
    class program
    {
        static void Main(string[] args)
        {
            int[] heltal = new int[3];
            heltal[0] = 20;
            heltal[1] = 80;
            Console.WriteLine("Skriv ett tal:");
            int nyttal = int.Parse(Console.ReadLine());
            heltal[2] = nyttal;
            Console.WriteLine(heltal[0] + " " + heltal[1] + " " + heltal[2]);
        }
    }
}