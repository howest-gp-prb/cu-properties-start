using System;
using System.Collections.Generic;
using System.Text;

namespace Prb.Properties.CORE
{
    public class Car
    {
        public string brand;
        public string color;
        public decimal price;
        public static int carCount;

        public Car() // Default constructor
        {
            brand = null;
            color = null;
            price = 0;
            carCount++;
        }

        public Car(string brand) : this() // Constructor ontvangt 1 parameter
        {
            this.brand = brand;
        }

        public Car(string brand, string color) : this() // Constructor ontvangt 2 parameters
        {
            this.brand = brand;
            this.color = color;
        }

        public Car(string brand, string color, decimal price) : this() // Constructor ontvangt 3 parameters
        {
            this.brand = brand;
            this.color = color;
            this.price = price;
        }

        public decimal PriceDifference(Car wagen)
        {
            return Math.Abs(this.price - wagen.price);
        }

        public static decimal PriceDifference(Car wagen1, Car wagen2)
        {
            return Math.Abs(wagen1.price - wagen2.price);
        }

        public override string ToString()
        {
            return $"{brand} - {color}";
        }
    }
}
