using System;
using Prb.Properties.CORE;

namespace Prb.Properties.CONS
{
    class Program
    {
        static void Main(string[] args)
        {
            Car firstCar;
            firstCar = new Car();

            firstCar.color = "zwart";
            firstCar.brand = "Hyundai";
            firstCar.price = 15000M;

            Car secondCar;
            secondCar = new Car();

            secondCar.color = "wit";
            secondCar.brand = "Ford";
            secondCar.price = 9000M;

            Car thirdCar = new Car("Audi", "blauw", 25000M);

            decimal priceDifference = Car.PriceDifference(firstCar, thirdCar);

            Console.WriteLine($"De nieuwe auto is een {firstCar.brand}, is {firstCar.color} van kleur en kost {firstCar.price}");
            Console.WriteLine("============");
            Console.WriteLine($"De tweede auto is een {secondCar.brand}, is {secondCar.color} van kleur en kost {secondCar.price}");
            Console.WriteLine("============");
            Console.WriteLine($"De derde auto is een {thirdCar.brand}, is {thirdCar.color} van kleur en kost {thirdCar.price}");
            Console.WriteLine("============");
            Console.WriteLine($"We hebben nu {Car.carCount} auto's");

            Console.WriteLine("============");
            Console.WriteLine($"Prijsverschil tussen {firstCar.price} en {thirdCar.price} is {priceDifference}");

            Console.ReadLine();
        }
    }
}
