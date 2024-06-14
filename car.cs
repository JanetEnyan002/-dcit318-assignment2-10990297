using System;

// Define the IMovable interface
public interface IMovable
{
    void Move();
}

// Implement the Car class which implements IMovable
public class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

// Implement the Bicycle class which implements IMovable
public class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Program
{
    static void Main()
    {
        // Create instances of Car and Bicycle
        Car myCar = new Car();
        Bicycle myBicycle = new Bicycle();

        // Call the Move() method on each instance
        myCar.Move();
        myBicycle.Move();
    }
}
