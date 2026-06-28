using System;
using System.Diagnostics.Contracts;

class Character
{
    public int powerLevel = 100;
    public string characterName;

    public virtual void Attack()
    {
        Console.WriteLine($"Character {characterName} attacks!");
    }

    public virtual void Defend()
    {
        Console.WriteLine($"Character {characterName} is defending!");
    }

    public virtual void PowerLevel()
    {
        Console.WriteLine($"I am {characterName} and my power level is {powerLevel}");
    }
}

class Warrior : Character
{
    public override void Attack()
    {
        Console.WriteLine($"Warrior {characterName} swings a sword!");
    }

    public override void Defend()
    {
        Console.WriteLine("Warrior raises a shield!");
    }
}

class Mage : Character
{
    public override void Attack() => Console.WriteLine("Mage casts a fireball!");

    public void Teleport() => Console.WriteLine("Mage teleports to a safe location!");
}

class Wizard : Mage
{
    public override void Attack() => Console.WriteLine("Wizard conjures a lightning bolt!");

    public void Heal() => Console.WriteLine("Wizard healed an ally!");

    public override void Defend() => Console.WriteLine("Wizard can't defend and died");
}

class Program
{
    static void Main()
    {
        Character[] team = { new Character(), new Mage(), new Warrior(), new Wizard() };
        Wizard Gandalf = new Wizard();
        Gandalf.Heal();
        Warrior Achilles = new Warrior();
        Achilles.Attack();
        Achilles.Defend();
        Achilles.PowerLevel();
        foreach (var c in team)
        {
            c.Attack();
            c.PowerLevel();
        }
    }
}