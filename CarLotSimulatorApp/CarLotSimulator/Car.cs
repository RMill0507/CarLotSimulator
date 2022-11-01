using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()//Default Contructor
        {
            CarLot.numberOfCars++;
            //ClassName.StaticMember
        }
        //Custom Constructor
        public Car(string year, string make, string model, string engineNoise, string honkNoise, string isdrivable)//PARAMETERS
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            isDrivable = isdrivable;
             
        }
        //Properties- Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        public string Make { get; set; }
        public string Model { get; set; }  
        public string Year { get; set; }    //Get and Set Makes it a property
        public string EngineNoise { get; set; } 
        public string HonkNoise { get; set; }   
        public string isDrivable { get; set; }

        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        public void MakeEngineNoise(string carNoise)
        {
            Console.WriteLine($"{carNoise}");
        }
        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine($"{honkNoise}");  
        }




    }



}
