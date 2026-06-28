using System;

class Vehicle
{
    public void Start()
    {
        Console.WriteLine("Vehicle started");
    }

    public void Stop()
    {
        Console.WriteLine("Vehicle stopped");
    }

    public void Honk()
    {
        Console.WriteLine("Vehicle honked");
    }
}

class Car : Vehicle
{
    public void Wheels()
    {
        Console.WriteLine("The car has four wheels");
    }
}

class Motorcycle : Vehicle
{
    public void Rev()
    {
        Console.WriteLine("The motorcycle revved up");
    }
}

class Bmw : Car
{
    public void Brand()
    {
        Console.WriteLine("This is a BMW");
    }
}

class Program
{
    static void Main()
    {
        Bmw myCar = new Bmw();
        myCar.Brand();
        myCar.Wheels();
        myCar.Start();
    }
}