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


            carsForSale++;
        }

        public void DisplayCar()
        {
            Console.WriteLine("Make: {0} \n Model: {1} \n Price:£{2:N0}.", make, model, price, sold, airBag);
            if (sold)
            {
                Console.WriteLine("This car has been sold.");
            }
            else
            {
                Console.WriteLine("This car is availible to buy");
            }

            Console.WriteLine();

        }

        public void sellCar(int price)
        {
            this.sold = true;
            this.price = price;


            carsForSale--;

            Console.WriteLine("This car {0} has been sold {1:N0}", this.make, this.price);
            Console.WriteLine();
        }

        public static void DisplayAllCars(List<Car>carList)
        {
            int totalValueSold = 0;
            int totalValueAvailable = 0;

            Console.WriteLine("The details of the cars on our books are: ");
            Console.WriteLine();

            //go through the car list, displaying details and calculating totals

            foreach (Car item in carList)
            {
                Console.WriteLine("Make: {0} \n Model: {1} \n Price:£{2:N0}.", item.make, item.model, item.price, item.sold, item.airBag);
                if (item.sold)
                {
                    Console.WriteLine("This car has been sold");
                    totalValueSold += item.price;
                }
                else
                {
                    Console.WriteLine("This car is available to buy");
                    totalValueAvailable += item.price;
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            //display summary data
            Console.WriteLine("The number of cars for sale:" + Car.carsForSale);
            Console.WriteLine();
            Console.WriteLine("The total value of cars sold:£{0:N0}", totalValueSold);
            Console.WriteLine("The total valeu available: £{0:N0}", totalValueAvailable);
            Console.WriteLine();

        }
    }

    class Program
    {
         static void Main(string[] args)
        {
            //initialise the static variable
            Car.carsForSale = 0;

            //initialise a list of cars for use in the non-static 
            //DisplayAllCars method

            List<Car>carList = new List<Car>();

            //instantiate car objects and give values to their fields using add method, 
            //incrementing the static variable each time a house is added and adding each
            //house to the list

            Car car1 = new Car("BMW", "serie 1", 10000);
            carList.Add(car1);


            Car car2 = new Car("audi", "A3", 10000);
            carList.Add(car2);


            Car car3 = new Car("VW", "Passat", 10000);
            carList.Add(car3);

            //display the details of the cars

            Car.DisplayAllCars(carList);

            //sell a car
            car1.sellCar(10000);

            //display the details of the car
            Car.DisplayAllCars(carList);
        }
    }
}




















            //instantiate car objects and give values to their fields, 
            //incrementing the static variable each time a car is added
            /*Car car1 = new Car();
            car1.make = "BMW";
            car1.model = "serie 1";
            car1.price = 10000;

            Car.carsForSale++;

            Car car2 = new Car();
            car2.make = "audi";
            car2.model= "A3";
            car2.price = 10000;

            Car.carsForSale++;

            Car car3 = new Car();
            car3.make = "vw";
            car3.model = "passat";
            car3.price = 10000;

            Car.carsForSale++;

            //display the details of the car

            Console.WriteLine("here are the cars we have in stock");
            Console.WriteLine();
            Console.WriteLine("\n the make of this car is:" + car1.make + "\n the model of tis car is: " + car1.model +  "\n the price is " + car1.price  );
            Console.WriteLine();
            Console.WriteLine("\n the make of this car is: " + car2.make + "\n the model of tis car is: " + car2.model +  "\n the price is "  + car2.price);
            Console.WriteLine();
            Console.WriteLine("\n the make of this car is: " + car3.make + "\n the model of tis car is: " + car3.model +   "\n the price is " + car3.price);
            Console.WriteLine();


            //display the total number for sale
            Console.WriteLine();
            Console.WriteLine("The total number of car for sale is: " + Car.carsForSale);



        }
    }

}*/