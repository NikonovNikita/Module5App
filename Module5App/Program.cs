using System;
using System.Reflection.Metadata;

class Program
{
    public static void Main(string[] args)
    {
        (string name, string[] Dishes) User;

        Console.WriteLine("Введите ваше имя ");
        User.name = Console.ReadLine();
        User.Dishes = new string[5];
        
        for(int i = 0; i <= User.Dishes.GetUpperBound(0); i++)
        {
            Console.Write("Введите ваше любимое блюдо номер {0} ", i + 1);
            User.Dishes[i] = Console.ReadLine();
        }
        Console.WriteLine("Ваше имя {0}", User.name);

        int x = 1;
        foreach (var num in User.Dishes)
        {
            Console.WriteLine("Ваше любимое блюдо номер {0} - {1}", x, num);
            x++;
        }
    }
}
