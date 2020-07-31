using System;

namespace MethodOveriding
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();
            person.Name = "Niraj";
            person.Age = 22;
            person.Email = "nirajdahal09@gmail.com";
            Console.WriteLine(person.ToString());

        }
    }
}

public abstract class Car
{
    public virtual void StartCar()
    {
        Console.WriteLine("Turn key and start");
    }
    public abstract void SetClock();
}
