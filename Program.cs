using System;

namespace arrayAverage
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            Console.WriteLine("please enter 5 numbers to be averaged. Press return after each one.");

            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());


                if (i != (numbers.Length - 1))
                {
                    Console.WriteLine("Enter another number");
                }

            }

            Console.WriteLine("thank you for entering your numbers");

            double total = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }

            double average = total / numbers.Length;

            Console.WriteLine("the average of your numbers is {0}", average);


        }

    }

}



           





            /*int firstNum = 0;
            int secondNum = 0;
            int thirdNum = 0;
            int fourthNum = 0;
            int fifthNum = 0;
            int total = 0;
            double average = 0;

            Console.WriteLine("please enter 5 numbers to be averaged. Press return after each one.");

            Console.WriteLine("Please, enter first number");
            firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please, enter second number");
            secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please, enter third number");
            thirdNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please, enter fourth number");
            fourthNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please, enter fifth number");
            fifthNum = Convert.ToInt32(Console.ReadLine());



                int[] inputNum = { firstNum, secondNum, thirdNum, fourthNum, fifthNum };

                for (int i = 0; i < inputNum.Length; i++)
                {

                    total += inputNum[i];
                    Console.WriteLine(total);
                }

                average = total / inputNum.Length;
                Console.WriteLine("Your average is " + average);*/








            /*Console.WriteLine("please enter 5 numbers to be averaged. Press return after each one.");

            int[] inputNum = new int[5];


            for (int i = 0; i < inputNum.Length; i++)
            {

                //Console.WriteLine("please enter a number");
                inputNum[i] = Convert.ToInt32(Console.ReadLine());

                if (i != (inputNum.Length - 1)) 
                {
                    Console.WriteLine("Please enter another number: ");

                }

            }

            Console.WriteLine("thank you for entering your numbers");


            double total = 0;

            for (int i = 0; i < inputNum.Length; i++)
            {
                total += inputNum[i];
            }

            double average = total / inputNum.Length;

            Console.WriteLine("the average of your numbers is {0}", average);*/















