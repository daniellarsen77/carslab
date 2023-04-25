namespace CarsLab
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Honda", "NSX", 2022, 20000.00M);
            Car car2 = new Car("Toyota", "Supra", 2022, 18000.00M);
            Car car3 = new Car("Nissan", "GTR R33", 2022, 19000.00M);

            UsedCar usedCar1 = new UsedCar("Ford", "Tarus SHO", 2018, 12000.00M, 50000.0);
            UsedCar usedCar2 = new UsedCar("Chevrolet", "Z06", 2017, 10000.00M, 60000.0);
            UsedCar usedCar3 = new UsedCar("Jeep", "Trackhawk", 2015, 9000.00M, 70000.0);

            Console.WriteLine("Welcome to our car dealership!");

            Console.WriteLine("Here are the cars we have in stock:");
            Car.ListCars();

            Console.WriteLine("Enter the number of the car you would like to purchase:");
            int carNumber = int.Parse(Console.ReadLine());

            Car selectedCar = Car.carList[carNumber - 1];
            Console.WriteLine("You have selected the following car:");
            Console.WriteLine(selectedCar.ToString());

            Car.Remove(carNumber);

            Console.WriteLine("Here is the updated list of cars:");
            Car.ListCars();

            Console.WriteLine("Thank you for your purchase!");
        }
    }


}