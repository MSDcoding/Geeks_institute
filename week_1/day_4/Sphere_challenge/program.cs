using System;
using System.Collections.Generic;

class Sphere : IComparable<Sphere>
{
    private double radius;

    public double Radius
    {
        get => radius;
        set => radius = value >= 0 ? value : 0;
    }

    public double Diameter
    {
        get => 2 * radius;
        set => radius = value >= 0 ? value / 2 : 0;
    }

    public Sphere(double radius = 0)
    {
        Radius = radius;
    }

    public Sphere(double value, bool isRadius)
    {
        if (isRadius) Radius = value;
        else Diameter = value;
    }

    public double Volume => (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
    public double SurfaceArea => 4 * Math.PI * Math.Pow(radius, 2);

    public static Sphere operator +(Sphere s1, Sphere s2)
    {
        if (s1 is null || s2 is null) return new Sphere(0);
        return new Sphere(s1.Radius + s2.Radius);
    }

    public static bool operator >(Sphere s1, Sphere s2)
    {
        if (s1 is null || s2 is null) return false;
        return s1.Volume > s2.Volume;
    }

    public static bool operator <(Sphere s1, Sphere s2)
    {
        if (s1 is null || s2 is null) return false;
        return s1.Volume < s2.Volume;
    }

    public static bool operator ==(Sphere s1, Sphere s2)
    {
        if (ReferenceEquals(s1, s2)) return true;
        if (s1 is null || s2 is null) return false;
        return s1.Radius == s2.Radius;
    }

    public static bool operator !=(Sphere s1, Sphere s2)
    {
        return !(s1 == s2);
    }

    public int CompareTo(Sphere other)
    {
        if (other is null) return 1;
        return Radius.CompareTo(other.Radius);
    }

    public override string ToString()
    {
        return $"Sphere: Radius = {Radius}, Diameter = {Diameter}, Volume = {Volume:F2}, Surface Area = {SurfaceArea:F2}";
    }

    public override bool Equals(object obj)
    {
        if (obj is Sphere s) return this == s;
        return false;
    }

    public override int GetHashCode()
    {
        return Radius.GetHashCode();
    }
}

class Program
{
    static void Main()
    {
        Sphere s1 = new Sphere(5);
        Sphere s2 = new Sphere(10, false);
        Sphere s3 = s1 + s2;

        Console.WriteLine(s1);
        Console.WriteLine(s2);
        Console.WriteLine(s3);

        Console.WriteLine(s1 > s2);
        Console.WriteLine(s1 < s2);
        Console.WriteLine(s1 == s2);
        Console.WriteLine(s1 != s2);

        List<Sphere> spheres = new List<Sphere> { s1, s2, s3 };
        spheres.Sort();

        Console.WriteLine("Sorted by radius:");
        foreach (var s in spheres)
            Console.WriteLine(s);
    }
}
