   using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

namespace CarShop
{

    public class Car

    //create a blueprint for a car object
    //non-static or instance fields
    {
        public string make = "";
        public string model = "";
        public int price = 0;
        public bool sold = false;
        public bool airBag = false;

        //static field
        public static int carsForSale = 0;


        //the AddDetailsOfCar method has been changed to a constructor by
        //1. giving it the same name as the class
        //2. removing the return type
        public Car(string make, string model, int price)
        {

            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = false;
            airBag = false;

            carsForSale++;
        }

        public Car(string make, string model, int price, bool airBag)
        {

            this.make = make;
            this.model = model;
            this.price = price;
            sold = false;
            this.airBag = airBag;

            carsForSale++;
        }


        class Program
        {
            static void Main(string[] args)
            {
                //initialise the static variable
                Car.carsForSale = 0;

                //initialise a list of cars for use in the non-static 
                //DisplayAllCars method
                List<Car> carList = new List<Car>();

                //variables needed for user input

                string response = "";
                string make = "";
                string model = "";
                int price = 0;


                do
                {
                    Console.WriteLine("Please tipe A to add a car to the list or X to exit:");
                    response = Console.ReadLine().ToUpper();

                    if (response == "A")
                        {
                        Console.WriteLine("Please enter the Make of the vehicle:");
                        make = Console.ReadLine();

                        Console.WriteLine("Please enter the Model of the vehicle:");
                        model = Console.ReadLine();

                        Console.WriteLine("Please enter the Price of the vehicle:");
                      price = Convert.ToInt32(Console.ReadLine());

                        Car myCar = new Car(make, model, price);
                        carList.Add(myCar);

                        Console.WriteLine("\nHere are the corent List of cars in stock:\n");
                        Console.WriteLine();

                        foreach (Car car in carList)
                        {
                            Console.WriteLine("Make: {0}, Model: {1}, price {2:N0}.", make, model, price);
                            Console.WriteLine();
                        }
                    }
                }
                while (response != "X");
                Console.WriteLine("Exit succesfull");

            }


        }

    }

}


               
