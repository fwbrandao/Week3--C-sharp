using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace averageAssessment
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //The application prompts the user to enter as many numbers as they want to, 
            //then offers them the choice of getting the average of the list, displaying the list, 
            //sorting the list or exiting the program.


            //Prompt user to enter numbers;
            Console.WriteLine("Please enter as many number as you want to be averaged.");


            //Ask user if want to add number or not.
            Console.WriteLine("Would you like to add a number to the list? (y/n):");

            //create a list of numbers
            List<int> myNumbers = new List<int>() { };

            int numberToAdd = 0;
            char userSelection = ' ';
            double total = 0D;
            double average = 0D;


            //Loop the options.
            do

            //user press Y to enter number or N to no.
            {
                //get user input and convert to char and lower case
                Console.WriteLine("Press Y to add number or N to not.");
                userSelection = Convert.ToChar(Console.ReadLine().ToLower());


                if (userSelection == 'y')
                {
                    //get numbers from user
                    Console.WriteLine("please, tipe your number.");
                    numberToAdd = Convert.ToInt32(Console.ReadLine().ToLower());
                    myNumbers.Add(numberToAdd);
                    Console.WriteLine("Number " + numberToAdd + " will be added");
                }


                //get all numbers if N is pressed.
            } while (userSelection != 'n');

            foreach (int number in myNumbers)
            {
                //display numbers
                Console.WriteLine(number);
            }

            //Calculate total and average for the numbers entered.
            Console.WriteLine("thank you for entering your numbers");



            //Give options for user to average, display, sort or exit.
            do

            {
                //prompt user about options.
                Console.WriteLine("Type ‘A’ to get the average of the list, 'D' to display the list, ‘S’ to sort it, or ‘X’ to exit:");
                Console.WriteLine("Please press A, D, S or X to exit:");

                //get user input and convert to char and lower case
                userSelection = Convert.ToChar(Console.ReadLine().ToLower());

                //carriage return
                Console.WriteLine();

                //choose a reply based on the user's input, looping until a valid reply is received
                switch (userSelection)
                {
                    case 'a':

                        for (int i = 0; i < myNumbers.Count; i++)
                        {
                            total += myNumbers[i];
                        }
                        average = total / myNumbers.Count;

                        Console.WriteLine("the average of your numbers is {0}", average);
                        Console.WriteLine("Here are your average: " + average);
                        break;

                    case 'd':
                        foreach (double d in myNumbers)
                            Console.WriteLine(d);
                        break;

                    case 's':
                        myNumbers.Sort();
                        foreach(double d in myNumbers)
                            Console.WriteLine(d);
                        break;

                    default:
                        userSelection = ' ';
                        break;
                }
                        
                        //display the reply
                        
                        Console.WriteLine();

                //end loop. 
            } while (userSelection == 'x') ;

         }
     }
 }

