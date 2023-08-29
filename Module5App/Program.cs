using System;
using System.Reflection.Metadata;

class MainClass
{
    public static void Main(string[] args)
    {
        (string name, int age) Anketa;
        Console.Write("Enter your name ");
        Anketa.name = Console.ReadLine();
        Console.Write("Enter your age in numbers ");
        Anketa.age = int.Parse(Console.ReadLine());

        Console.WriteLine("Your name is {0}", Anketa.name);
        Console.WriteLine("Your age is {0}", Anketa.age);

        string[] favColors = new string[3];
        for(int i = 0; i < favColors.Length; i++)
        {
        favColors[i] = ShowColor(Anketa.name, Anketa.age);
        }

        Console.WriteLine("Ваши любимые цвета:");
        foreach (var num in favColors)
        {
            Console.Write(num + " ");
        }
    }
    
    static string ShowColor(string UserName, int UserAge)
    {
        Console.Write("{0}, {1},\nНапишите свой любимый цвет на английском с маленькой буквы ",UserName, UserAge);
        var Color = Console.ReadLine();
        switch (Color)
        {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
                break;

            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
                break;

            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
                break;
            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is yellow!");
                break;
        }
        return Color;
    }
}
