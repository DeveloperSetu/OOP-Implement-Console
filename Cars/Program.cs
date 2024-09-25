using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
                /*  1.Create a public class called Car.
                    2.	Define three private fields : car make, car model, car price.
                    3.	Define three public properties : Make,Model and Price
                    4.	Create a Console application to do the following:
                        a.	Create two car objects
                        b.	Display the information of both cars
                        c.	Find and display the information of the more expensive car */
    public class Car
    {
        // Private Fields
        string carMake;
        string carModel;
        decimal Price;
        // Public Properties
        public string _Make { get { return carMake; } set { carMake = value; } }
        public string _Model { get { return carModel; } set { carModel = value; } }
        public decimal _Price { get { return Price; } set { Price = value; } }

        // Car Details Display Method
        public void DisplayCar()
        {
            Console.WriteLine($"Car Details:\n\t Car Make: {carMake},\n\t Car Model: {carModel},\n\t Car Price: {Price} Taka(Only)");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create Object/instance of Car
            Car bmw = new Car { _Make = "BMW", _Model = "F40", _Price = 695999.99M };       
            bmw.DisplayCar();
            Car toyota = new Car { _Make = "Toyota", _Model = "Prius", _Price = 995000.50M };
            toyota.DisplayCar();

            // Expensive Car
            Car[] carAll = { bmw, toyota };

            decimal basePrice = carAll[0]._Price;
            int index = 0;
            for (int i = 1; i < carAll.Length; i++)
            {
                if (carAll[i]._Price > basePrice)
                {
                    basePrice = carAll[i]._Price;
                    index = i;
                }
            }
            Console.WriteLine($"\nMost Expensive Car Details Bellow");
            carAll[index].DisplayCar();

            // Expensive Car 2nd Way
            decimal[] priceAll = new decimal[carAll.Length];
            for(int i = 0; i < carAll.Length; i++)
            {
                priceAll[i] = carAll[i]._Price;
            }
            decimal maxPrice = priceAll.Max();
            int indexMaxprice = Array.IndexOf(priceAll, maxPrice);        
            Console.WriteLine($"\nMost Expensive Car Details Bellow (2nd Way to solve)");
            carAll[indexMaxprice].DisplayCar();

            Console.ReadKey();
            
        }
    }
}
