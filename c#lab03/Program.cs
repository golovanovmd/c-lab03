using System;

struct Vector
{
    public double x, y, z;

    public Vector(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    private double Length()
    {
        return Math.Sqrt(x * x + y * y + z * z);
    }

    public static Vector operator +(Vector v1, Vector v2)
    {
        return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
    }

    public static double operator *(Vector v1, Vector v2)
    {
        return v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
    }

    public static Vector operator *(Vector v, double num)
    {
        return new Vector(num * v.x, num * v.y, num * v.z);
    }

    public static Vector operator *(double num, Vector v)
    {
        return new Vector(num * v.x, num * v.y, num * v.z);
    }

    public static bool operator >(Vector v1, Vector v2)
    {
        return v1.Length() > v2.Length();
    }

    public static bool operator <(Vector v1, Vector v2)
    {
        return v1.Length() < v2.Length();
    }

    public static bool operator >=(Vector v1, Vector v2)
    {
        return v1.Length() >= v2.Length();
    }

    public static bool operator <=(Vector v1, Vector v2)
    {
        return v1.Length() <= v2.Length();
    }

    public static bool operator ==(Vector v1, Vector v2)
    {
        return v1.Length() == v2.Length();
    }

    public static bool operator !=(Vector v1, Vector v2)
    {
        return v1.Length() != v2.Length();
    }
}

class Program
{
    static void Main()
    {
        Vector v1 = new Vector(0, 3, 4);
        Vector v2 = new Vector(5, 0, 12);
        Console.WriteLine($"v1 = ({v1.x}, {v1.y}, {v1.z})");
        Console.WriteLine($"v2 = ({v2.x}, {v2.y}, {v2.z})");

        Vector v3 = v1 + v2;
        Console.WriteLine($"v3 = ({v3.x}, {v3.y}, {v3.z})");

        double v4 = v1 * v2;
        Console.WriteLine($"v1 * v2 = {v4}");

        Vector v5 = 2 * v1;
        Console.WriteLine($"v5 = ({v5.x}, {v5.y}, {v5.z})");

        Console.WriteLine(v1 > v2);
        Console.WriteLine(v1 < v2);
        Console.WriteLine(v1 >= v2);
        Console.WriteLine(v1 <= v2);
        Console.WriteLine(v1 == v2);
        Console.WriteLine(v1 != v2);
    }
}