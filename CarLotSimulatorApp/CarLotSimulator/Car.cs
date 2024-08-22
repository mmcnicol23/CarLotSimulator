using System;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace CarLotSimulator;

public class Car
{
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public string IsDriveable { get; set; }

    public void CarDetails()
    {
        Console.WriteLine($"Check out this {Year} {Make} {Model}!");
        Console.WriteLine($"This car has a {EngineNoise} level of engine noise and a {HonkNoise} level of honk noise.");
        Console.WriteLine($"Is this {Model} driveable? {IsDriveable}!"); 
    }
    //for the Custom Constructor
    public Car(int year, string make, string model, string engineNoise, string honkNoise, string isDriveable)
    {
        Year = year;
        Make = make;
        Model = model;
        EngineNoise = engineNoise;
        HonkNoise = honkNoise;
        IsDriveable = isDriveable;
    }
    //Need an empty default constructor to satisfy the Dot Notation and Object Initializer paramters:
    public Car()
    {
        
    }

    
}