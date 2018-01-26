using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace listOfBooks
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            


            Console.WriteLine("Here are the books in or list. Press A to add book or X to exit.");

            List<string> myBooks = new List<string>() { "Ready Player One", "The Girl on the Train" };

            string bookToAdd = "";
            string bookToRemove = "";
            char userSelection = ' ';

            do
            {
                Console.WriteLine("Press A to add book or X to exit.");
                userSelection = Convert.ToChar(Console.ReadLine().ToLower());

                if (userSelection == 'a'){
                    
                    Console.WriteLine("please, tipe the name of your book.");
                    bookToAdd = Convert.ToString(Console.ReadLine().ToLower());
                    myBooks.Add(bookToAdd);
                }


                else{
                    Console.WriteLine("here is your list");
                }

                Console.WriteLine(myBooks);

            } while (userSelection != 'x' );

              



            }
         }
    }

