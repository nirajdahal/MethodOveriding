using System;

public class Tesla : Car
{
    public override void StartCar()
    {
        Console.WriteLine("Think about your destination");
    }
    public override void SetClock()
    {
        Console.WriteLine("I am setting the time in Tesla");
    }
}