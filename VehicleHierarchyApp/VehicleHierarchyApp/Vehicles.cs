using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleHierarchyApp
{
    public class Vehicle
    {
        public string Name { get; set; }

        public string Icon { get; set; }
        public bool IsRunning { get; set; } = false;    
        public string Start()
        {
            IsRunning = true;
            return $"{Icon} {Name} engine is purring...";
        }

        public string Stop()
        {
            IsRunning = false;
            return $"{Icon} {Name} shut down";
        }
    }

    public class Car : Vehicle
    {
        public Car() { Name = "Sports Car"; Icon = "🚗"; }
        public string Honk()
        {
            if (IsRunning)
            {
                return $"{Icon} The sports car honked";
            }
            else
            {
                return $"{Icon} The sports car is off, silence";
            }
        }
    }

    public class Motorcycle : Vehicle
    {
        public Motorcycle() { Name = "Street Bike"; Icon = "🏍️"; }
        public string Rev()
        {
            if (IsRunning)
            {
                return $"{Icon} The street bike revved up";
            }
            else
            {
                return $"{Icon} The street bike stayed silent";
            }
        }
    }

    public class Helicopter : Vehicle
    {
        public Helicopter() { Name = "Chopper"; Icon = "🚁"; }
        public string Fly()
        {
            if (IsRunning)
            {
                return $"{Icon} The chopper flew";
            }
            else
            {
                return $"{Icon} The chopper stayed put";
            }
        }
    }

    public class Truck : Vehicle
    {
        public Truck() { Name = "Truck"; Icon = "🚚"; }
        public string Deliver()
        {
            if (IsRunning)
            {
                return $"{Icon} The truck delivered items";
            }
            else
            {
                return $"{Icon} The truck didn't move";
            }
        }
    }
}
