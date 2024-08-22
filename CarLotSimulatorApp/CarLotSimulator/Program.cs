using System;
using CarLotSimulator;
{
   //Dot Notation:
   var car1 = new Car();
   car1.Year = 2012;
   car1.Make = "Jeep";
   car1.Model = "Wrangler";
   car1.EngineNoise = "medium";
   car1.HonkNoise = "loud";
   car1.IsDriveable = "Yes";
    
   //Object initializer: 
   var car2 = new Car()
    {
        Year = 2024,
        Make = "Chevrolet",
        Model = "Corvette",
        EngineNoise = "quiet",
        HonkNoise = "medium",
        IsDriveable = "Yes"
    };
    
   //Custom constructor:
   var car3 = new Car(year: 1989, make: "Honda", model: "Civic", engineNoise: "loud", honkNoise: "quiet",
       isDriveable: "No");
   
   //Here is my output about the above vehicles: 

    Console.WriteLine("Car 1 Details:");
    car1.CarDetails();
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine("Car 2 Details:");
    car2.CarDetails();
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine("Car 3 Details:");
    car3.CarDetails();
   
}

