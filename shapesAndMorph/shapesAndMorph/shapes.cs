using System;
using System.Collections.Generic;
using System.Text;

namespace shapesAndMorph;

public abstract class Shape
{
    public string Name { get; protected set; }
    public Shape(string name) => Name = name;
    public abstract double Area();
    public abstract double Perimeter();
}

public class Circle : Shape
{
    private double _radius;
    public Circle(double radius) : base("Circle") => this._radius = radius;
    public override double Area() => Math.PI * _radius * _radius;
    public override double Perimeter() => 2 * Math.PI * _radius;
}

public class Square : Shape
{
    private double _sidelength;
    public Square(double sidelength) : base("Square") => this._sidelength = sidelength;
    public override double Area() => _sidelength * _sidelength;
    public override double Perimeter() => 4 * _sidelength;
}
public class Rectangle : Shape
{
    private double _sidelength1;
    private double _sidelength2;
    public Rectangle(double sidelength1, double sidelength2) : base("Rectangle")
    {
        this._sidelength1 = sidelength1; this._sidelength2 = sidelength2;
    }
    public override double Area() => _sidelength1 * _sidelength2;
    public override double Perimeter() => 2 * (_sidelength1 + _sidelength2);
}
public class Triangle : Shape
{
    private double b;
    private double h;
    private double hypotenuse;
    public Triangle(double b, double h) : base("Triangle")
    {
        this.b = b;
        this.h = h;
        hypotenuse = Math.Sqrt(b * b + h * h);
    }
    public override double Area() => (b * h) / 2;
    public override double Perimeter() => b + h + hypotenuse;

    /* alternate code
    private double _sidelength1;
    private double _sidelength2;
    private double _sidelength3;
    private double _semiperimeter;
    public Triangle(double sidelength1, double sidelength2, double sidelength3) : base("Triangle")
    {
        this._sidelength1 = sidelength1;
        this._sidelength2 = sidelength2;
        this._sidelength3 = sidelength3;
        _semiperimeter = (sidelength1 + sidelength2 + sidelength3) / 2;
    }
    public override double Area() => Math.Sqrt(_semiperimeter * (_semiperimeter - _sidelength1) * (_semiperimeter - _sidelength2) * (_semiperimeter - _sidelength3));
    public override double Perimeter() => _sidelength1 + _sidelength2 + _sidelength3;
    */
}