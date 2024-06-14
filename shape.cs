using System;

// Define an abstract class Shape
public abstract class Shape
{
    // Abstract method GetArea to be implemented by derived classes
    public abstract double GetArea();
}

// Derived class Circle inheriting from Shape
public class Circle : Shape
{
    // Fields specific to Circle
    private double radius;

    // Constructor for Circle
    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Implementing the GetArea method for Circle
    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

// Derived class Rectangle inheriting from Shape
public class Rectangle : Shape
{
    // Fields specific to Rectangle
    private double length;
    private double width;

    // Constructor for Rectangle
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    // Implementing the GetArea method for Rectangle
    public override double GetArea()
    {
        return length * width;
    }
}

class Program
{
    static void Main()
    {
        // Create instances of Circle and Rectangle
        Circle myCircle = new Circle(3.5);
        Rectangle myRectangle = new Rectangle(4, 5.5);

        // Calculate and display areas
        Console.WriteLine($"Area of Circle: {myCircle.GetArea():F2} square units");
        Console.WriteLine($"Area of Rectangle: {myRectangle.GetArea():F2} square units");
    }
}
