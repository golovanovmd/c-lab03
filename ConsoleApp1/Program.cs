using System;

class Car : IEquatable<Car> 
{
    public string Name;
    public string Engine;
    private double MaxSpeed;

    public Car(string name, string engine, double maxSpeed)
    {
        Name = name;
        Engine = engine;
        MaxSpeed = maxSpeed;
    }

    public override string ToString()
    {
        return Name;
    }

    public bool Equals(Car other)
    {
        if (other is null) return false;
        return Name == other.Name && Engine == other.Engine && MaxSpeed.Equals(other.MaxSpeed);
    }

    public override bool Equals(Object obj)
    {
        if (obj == null) return false;
        Car personObj = obj as Car;
        if (personObj == null) return false;
        return Equals(personObj);
    }
}

class CarsCatalog
{
    private Car[] cars;

    public CarsCatalog(params Car[] cars)
    {
        this.cars = cars;
    }

    public string this[int index]
    {
        get { return $"Name = {cars[index].Name}, engine = {cars[index].Engine}"; }
    }
}

class Program
{
    static void Main()
    {
        Car car1 = new Car("Car 1", "Car 1 Engine", 110);
        Car car2 = new Car("Car 2", "Car 2 Engine", 120);

        Console.WriteLine(car1.ToString());
        Console.WriteLine(car2.ToString());

        CarsCatalog catalog = new CarsCatalog(car1, car2);
        Console.WriteLine(catalog[0]);
    }
}