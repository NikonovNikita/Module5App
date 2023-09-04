using System;
using System.Reflection.Metadata;

class MainClass
{
    static void ChangeAge(ref int age)
    {
        Console.WriteLine("Enter age");
        age = int.Parse(Console.ReadLine());
    }
    static void GetName(ref string name)
    {
        Console.WriteLine("Enter name");
        name = Console.ReadLine();
    }
    public static void Main(string[] args)
    {
        var someName = "Евгений";
        Console.WriteLine(someName);
        GetName(ref someName);      
        Console.WriteLine(someName);
        var someAge = 18;
        ChangeAge(ref someAge);
        Console.WriteLine(someAge);
    }
}

