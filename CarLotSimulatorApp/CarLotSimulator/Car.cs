using System;

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
  
}