using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsLab
{
    using System;

    public class UsedCar : Car
    {
        private double mileage;

        public UsedCar(string make, string model, int year, decimal price, double mileage) : base(make, model, year, price)
        {
            this.mileage = mileage;
        }

        public override string ToString()
        {
            return $"{base.ToString()} (Used) with {mileage} miles";
        }
    }


}
