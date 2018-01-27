using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookCollectionAssessment
{
    class Book
    {

        public string title;
        public string author;
        public int isbn;
        public decimal price;

        public Book(string title, string author, int isbn, decimal price)
        {

            this.title = title;
            this.author = author;
            this.isbn = isbn;
            this.price = price;

        }

        class Program

        {
            static void Main(string[] args)
            {
                //declare the variables needed for user input
                char response;
                string title;
                string author;
                int isbn;
                decimal price;
                int index;

                //create an empty list of book objects and add a book 
                //(it's easier to test the code if there is already some data)

                List<Book> allBooks = new List<Book>();
                Book book1 = new Book("The lord of the rings", "J. R. R. Tolkien", 123456, 9.99M);
                allBooks.Add(book1);

                //tell the user what the program is about
                Console.Write("Here is your book collection.  Type A to add a book, L to list all the books,");
                Console.WriteLine("D to delete a book, S to sort the books, F to find a book or X to exit.");
                Console.WriteLine();

                //repeat until the user decides to exit the program
                do
                {
                    //ask the user what they want to do and read the response, converting it to a character
                    Console.WriteLine("What would you like to do? \nA (add) \nL (list) \nD (delete) \nS (sort), \nF (find) \nX (exit)");
                    response = Convert.ToChar(Console.ReadLine().ToLower());

                    switch (response)
                    {
                        case 'a':
                            //get the details of the book the user wants to add
                            Console.WriteLine("Please, enter the title of the book to add:");
                            title = Console.ReadLine();
                            Console.WriteLine("Please, enter the author of the book:");
                            author = Console.ReadLine();
                            Console.WriteLine("Please, enter the ISBN of the book:");
                            isbn = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Please, enter the price of the book:");
                            price = Convert.ToDecimal(Console.ReadLine());
                            //instantiate a new book object with the user input and add it to the list
                            Book newBook = new Book(title, author, isbn, price);
                            allBooks.Add(newBook);
                            Console.WriteLine("The book {0} by {1} has been add", title, author);
                            Console.WriteLine("***");
                            break;

                        case 'l':
                            //display each book in the list
                            foreach (Book books in allBooks)
                            {
                                Console.WriteLine("title {0} author {1} isbn {2} price {3:N0}", books.title, books.author, books.isbn, books.price);
                                Console.WriteLine();
                            }
                            break;
                            //find out which book to delete
                            Console.WriteLine("Please, enter a book to be deleted: ");
                            title = Console.ReadLine();
                            //check if the book is in the list - if so, get its position
                            //index = allBooks.FindIndex(item => item.title == title);
                            Book bookToDelete = allBooks.Find(item => item.title == title);
                            //if the book was in the list (i.e. index was in range) remove it from the list, otherwise do nothing. 
                            //Give the user feedback
                            if (bookToDelete != null)
                            {
                                allBooks.Remove(bookToDelete);
                                Console.WriteLine("{0} has been deleted from the list", title);
                            }
                            else
                            {
                                Console.WriteLine("{0} was not found in the list.", title);
                            }
                            break;

                        case 's':
                            //this is a list of objects, so it must be sorted on one of the properties 
                            //of the objects.  The easiest way to do this is with a lambda expression
                            //as shown below
                            allBooks = allBooks.OrderBy(book => book.title).ToList();
                            Console.WriteLine("The list of books has been sorted");
                            break;

                        case 'f':
                            //get user input on book to find
                            Console.WriteLine("Please, enter the title of the book you want to find");
                            title = Console.ReadLine();
                            // this is a list of objects, so you can only search for one of the properties
                            //of the objects.  The easiest way to do this is with a lambda expression
                            //as shown below.  The .Find method returns the object, which can then be
                            //used
                            Book FoundBook = allBooks.Find(item => item.title == title);
                            if (FoundBook != null) 
                            {
                                Console.WriteLine("{0} is in the list.", FoundBook.title);
                            }
                            else
                            {
                                Console.WriteLine("{0} is not in the list", title);
                            }
                            break;
                        

                    }
                } while (response != 'x');
            }
        }
    }
}
    
