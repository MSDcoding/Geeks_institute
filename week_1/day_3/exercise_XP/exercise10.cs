//Dogs

using System;

class Dog
{
    public string name;
    public int height;

    public Dog(string n, int h)
    {
        name = n;
        height = h;
    }

    public void Bark()
    {
        Console.WriteLine(name + " goes woof!");
    }

    public void Jump()
    {
        int jumpH = height * 2;
        Console.WriteLine(name + " jumps " + jumpH + " cm high!");
    }
}

class Exercise10
{
    public static void Dogss()
    {
        Dog d1 = new Dog("Rex", 50);
        d1.Bark();
        d1.Jump();

        Dog d2 = new Dog("max", 20);
        d2.Bark();
        d2.Jump();

        if (d1.height > d2.height)
        {
            Console.WriteLine("The taller dog is " + d1.name);
        }
        else
        {
            Console.WriteLine("The taller dog is " + d2.name);
        }
    }
}
