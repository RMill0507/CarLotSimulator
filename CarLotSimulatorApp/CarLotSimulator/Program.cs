using System;

namespace CarLotSimulator
{
    class Program
    {

        static void Main(string[] args)
        {
            
                        
            
            
            
            var carLot = new CarLot();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            Car myCar = new Car();
            myCar.Make = "Chevy";
            myCar.Model = "Corvette";
            myCar.Year = "2023";
            myCar.EngineNoise = "Vroom";
            myCar.HonkNoise = "Beep Beep";
            myCar.isDrivable = "Yes";
            myCar.MakeEngineNoise(myCar.EngineNoise);
            myCar.MakeHonkNoise(myCar.HonkNoise);
            
            carLot.ParkingLot.Add(myCar);


            var my2ndCar = new Car()
            {
                Make = "Ford",
                Model = "Raptor",
                Year = "2010",
                EngineNoise = "vrooom",
                HonkNoise = "HONK HONK",
                isDrivable = "Ofcourse"
            };
            my2ndCar.MakeEngineNoise(my2ndCar.EngineNoise);
            my2ndCar.MakeHonkNoise(my2ndCar.HonkNoise);
            
            carLot.ParkingLot.Add(my2ndCar);   //ADDING 2ND CAR TO ParkingLot list

            var my3ndCar = new Car()
            {
                Make = "GMC",
                Model = "Sierra",
                Year = "2020",
                EngineNoise = "Vrum Vrum",
                HonkNoise = "HONK",
                isDrivable = "When it starts"

            };
            my3ndCar.MakeHonkNoise(my3ndCar.HonkNoise);
            my3ndCar.MakeEngineNoise(my3ndCar.EngineNoise);

            var my4thCar = new Car("2201", "Chevy", "SS", "VROOM VRoom", "HONK", "Maybe");

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");
            
            
            foreach(var vehicle in carLot.ParkingLot)
            {
                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}");
                Console.WriteLine(vehicle.EngineNoise);
            }

        
        
        
        
        
        
        }

    }
}
