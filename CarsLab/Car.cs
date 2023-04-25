using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsLab
{
    using System;
    using System.Collections.Generic;

    public class Car
    {
        protected string make;
        protected string model;
        protected int year;
        protected decimal price;

        public static List<Car> carList = new List<Car>();

        public Car()
        {
            make = "";
            model = "";
            year = 0;
            price = 0;
        }

        public Car(string make, string model, int year, decimal price)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;

            carList.Add(this);
        }

        public virtual string ToString()
        {
            return $"{year} {make} {model} (${price:N2})";
        }

        public static void ListCars()
        {
            for (int i = 0; i < carList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {carList[i].ToString()}");
            }
        }

        public static void Remove(int index)
        {
            carList.RemoveAt(index - 1);
        }
    }


}
