//Dogs

using System;

class Cat
{
    public string name;
    public int age;

    public Cat(string catName, int catAge)
    {
        name = catName;
        age = catAge;
    }
}

class Exercise9
{
    public static Cat GetOldestCat(Cat c1, Cat c2, Cat c3)
    {
        Cat oldest = c1;

        if (c2.age > oldest.age)
        {
            oldest = c2;
        }

        if (c3.age > oldest.age)
        {
            oldest = c3;
        }

        return oldest;
    }

    public static void cats()
    {
       
        Cat cat1 = new Cat("Mimi", 3);
        Cat cat2 = new Cat("Luna", 7);
        Cat cat3 = new Cat("Simba", 5);

        Cat oldestCat = GetOldestCat(cat1, cat2, cat3);

        Console.WriteLine("The oldest cat is " + oldestCat.name + ", and is " + oldestCat.age + " years old.");
    }
}

