using System;
using System.Collections.Generic;
namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            var lot = new CarLot();
            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
            

            //Now that the Car class is created we can instanciate 3 new cars
            var femiCar = new Car();
            femiCar.Make = "nissan";
            femiCar.Model = "altima";
            femiCar.IsDriveable = true;
            femiCar.EngineNoise = "*rumble*";
            femiCar.HonkNoise = "beep";

            lot.Cars.Add(femiCar);
            

            var kemiCar = new Car("kia", "serento", 2014, "vroom", "beeep", true);

            lot.Cars.Add(kemiCar);
           

            var yemi = new Car("ford", "focus", 2011, "vrooom", "beeep", true);

            lot.Cars.Add(yemi);
            
            //Set the properties for each of the cars
            //Call each of the methods for each car
            femiCar.MakeEngineNoise();
            femiCar.MakeHonkNoise();
            kemiCar.MakeEngineNoise();
            kemiCar.MakeHonkNoise();
            yemi.MakeEngineNoise();
            yemi.MakeHonkNoise();
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            
            
            foreach(var car in lot.Cars)
            {
                CarLot.numberOfCars++;
                Console.WriteLine($"# of cars {CarLot.numberOfCars}");
            }
        }
    }
}
