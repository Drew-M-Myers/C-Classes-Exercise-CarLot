using System;
using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();

            Car carOne = new Car();

            carOne.Year = 2014;
            carOne.Make = "Honda";
            carOne.Model = "Ridge Line";
            carOne.EngineNoise = "No";
            carOne.HonkNoise = "Beep";
            carOne.IsDriveable = true;

            lot.Cars.Add(carOne);

            var carTwo = new Car()
            {
                Year = 1998,
                Make = "Toyota",
                Model = "Camry",
                EngineNoise = "...",
                HonkNoise = "Toot",
                IsDriveable = false
            };

            lot.Cars.Add(carTwo);

            var carThree = new Car(2022, "Nissan", "Pathfinder", "Vroom", "Honk", true);

            lot.Cars.Add(carThree);

            carOne.MakeEngineNoise(carOne.EngineNoise);
            carOne.MakeHonkNoise(carOne.HonkNoise);
            carTwo.MakeEngineNoise(carTwo.EngineNoise);
            carTwo.MakeHonkNoise(carTwo.HonkNoise);
            carThree.MakeEngineNoise(carThree.EngineNoise);
            carThree.MakeHonkNoise(carThree.HonkNoise);

            Console.WriteLine("");
            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");
            Console.WriteLine("");

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year:{car.Year} Make:{car.Make} Model:{car.Model}");
            }
        }
    }
}
