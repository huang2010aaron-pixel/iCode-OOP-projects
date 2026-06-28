using System;

class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal sound");
    }

    public void Sleep()
    {
        Console.WriteLine("Animal sleeps");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Woof!");
    }

    public void Thirsty()
    {
        Console.WriteLine("Sipping Water");
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Meow!");
    }

    public void Play()
    {
        Console.WriteLine("Playing with yarn");
    }
}

class Program
{
    static void Main()
    {
        Dog buddy = new Dog();
        buddy.Speak();
        buddy.Thirsty();
        buddy.Sleep();
        Cat tabby = new Cat();
        tabby.Speak();
        tabby.Play();
        Animal arthur = new Animal();
        arthur.Speak();
        arthur.Sleep();
    }
}