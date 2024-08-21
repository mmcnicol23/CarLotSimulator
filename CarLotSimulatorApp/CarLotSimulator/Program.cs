using System;
using CarLotSimulator;
{
   var car1 = new Car()
    {
        Year = 2012,
        Make = "Jeep",
        Model = "Wrangler",
        EngineNoise = "medium",
        HonkNoise = "loud",
        IsDriveable = "Yes"
    };
   
    var car2 = new Car()
    {
        Year = 2024,
        Make = "Chevrolet",
        Model = "Corvette",
        EngineNoise = "quiet",
        HonkNoise = "medium",
        IsDriveable = "Yes"
    };
    
    var car3 = new Car()
    {
        Year = 1989,
        Make = "Honda",
        Model = "Civic",
        EngineNoise = "loud",
        HonkNoise = "quiet",
        IsDriveable = "No"
    };

    Console.WriteLine("Car 1 Details:");
    car1.CarDetails();
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine("Car 2 Details:");
    car2.CarDetails();
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine("Car 3 Details:");
    car3.CarDetails();
   
}