using System;

namespace riddle
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            Console.WriteLine("Hey, i've got a riddle for you!!!");
            Console.WriteLine("Why fish dont like basketball?");

            string riddle = "they dont like the net";

            string yourAnswer = Console.ReadLine().ToLower();

            while (yourAnswer != riddle)
            {
                Console.WriteLine("Wrong, try again");
                Console.ReadLine().ToLower();
            }
            if (yourAnswer == riddle)
            {
                Console.WriteLine("You've got it");
            }



        }
    }
}

