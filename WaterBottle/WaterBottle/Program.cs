using System;

class WaterBottle
{
    private int waterlevel = 0;
    public void Fill(int amounttoadd)
    {
        if (amounttoadd > 0)
        {
            if(waterlevel < 100)
            {
                waterlevel += amounttoadd;
            }
            else
            {
                waterlevel = 100;
            }
        }
    }

    public void Pour(int amounttoadd)
    {
        if (amounttoadd > 0)
        {
            if (waterlevel > 0)
            {
                waterlevel -= amounttoadd;
            }
            else
            {
                waterlevel = 0;
            }
        }
    }

    public int GetAmount()
    {
        return waterlevel;
    }
}

class Program
{
    static void Main()
    {
        WaterBottle myWaterBottle = new WaterBottle();
        Console.WriteLine(myWaterBottle.GetAmount());
        myWaterBottle.Fill(100);
        Console.WriteLine(myWaterBottle.GetAmount());
        myWaterBottle.Pour(70);
        Console.WriteLine(myWaterBottle.GetAmount());
        myWaterBottle.Pour(300);
        Console.WriteLine(myWaterBottle.GetAmount());
        myWaterBottle.Fill(200);
        Console.WriteLine(myWaterBottle.GetAmount());

    }
}