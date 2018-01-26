using System;

namespace dwarves
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };
            Console.WriteLine("here are the seven dwarves: ");

            for (int i = 0; i < sevenDwarves.Length; i++)
            {
                Console.WriteLine(sevenDwarves[i]);
            }

            Console.WriteLine(" The Food is ready:");

            for (int i = 0; i < sevenDwarves.Length; i++)
            {
                Console.WriteLine("Heres you food " + sevenDwarves[i]);
            }

            Console.WriteLine("The Drink is ready:");

            foreach (string dwarves in sevenDwarves)
            {
                Console.WriteLine("here is you drink " + dwarves);
            }

        }
    }
}









           
