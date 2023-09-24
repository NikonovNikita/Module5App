using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Xml.Linq;

class Program
{
    public static void Main(string[] args)
    {
        EnterData();
    }
    public static (string Name, string LastName, byte Age, bool PetsPresence, string[] ArrayPets, string[] ArrayColors) EnterData()
    {
        (string Name, string LastName, byte Age, bool PetsPresence, string[] ArrayPets, string[] ArrayColors) UserData;
        Console.Write("Добрый день! Введите свое имя: ");
        UserData.Name = Console.ReadLine();
        Console.Write("Введите свою фамилию: ");
        UserData.LastName = Console.ReadLine();
        Console.Write("Введите свой возраст цифрами: ");
        string CheckAge;
        byte TrueAge;
        
        do
        {
            CheckAge = Console.ReadLine();
        }
        while (CheckNum(in CheckAge, out TrueAge));
        
        UserData.Age = TrueAge;
        UserData.PetsPresence = CheckPets();
        if(UserData.PetsPresence == true)
        {
            UserData.ArrayPets = EnterPets();
        }
        else
        {
            UserData.ArrayPets = Array.Empty<string>();
        }
        UserData.ArrayColors = EnterColors();
        Console.WriteLine("Вас зовут: {0}, {1}", UserData.Name, UserData.LastName);
        Console.WriteLine("Ваш возраст: {0}", UserData.Age);
        Console.WriteLine("Наличие питомца: {0}", UserData.PetsPresence);
        Console.Write("Список ваших питомцев: ");
        foreach (var PetsNums in UserData.ArrayPets)
        {
            Console.Write(PetsNums + " ");
        }
        Console.Write("\nСписок ваших любимых цветов: ");
        foreach (var ColorsNums in UserData.ArrayColors)
        {
            Console.Write(ColorsNums + " ");
        }
        return UserData;
    }
    public static string[] EnterColors()
    {
        Console.Write("Сколько у вас favcolors? ");
        byte TrueNumColor;
        string HowManyColors;
        string[] FavColors = Array.Empty<string>();
        do
        {
            HowManyColors = Console.ReadLine();
        }
        while (CheckNum(in HowManyColors, out TrueNumColor));
        FavColors = new string[TrueNumColor];
        short TrueColor;
        bool Check = false;
        for (int i = 0; i < FavColors.Length; i++)
        {
            Console.WriteLine("Введите favцвет номер {0}", i + 1);
            do
            {
                FavColors[i] = Console.ReadLine();
                if (short.TryParse(FavColors[i], out TrueColor))
                {
                    Console.WriteLine("Цифры недопустимы! Повторите ввод");
                    Check = true;
                }
                else
                {
                    Check = false;
                }
            } while (TrueColor > short.MinValue && TrueColor < short.MaxValue && Check == true);
        }
        return FavColors;
    }
    public static string[] EnterPets()
    {
            byte TrueNum;
            string[] NickName = Array.Empty<string>();
            
            Console.Write("Сколько у вас питомцев? ");
            string HowMany;
            do
            {
                HowMany = Console.ReadLine();
            }
            while (CheckNum(in HowMany, out TrueNum));
            NickName = new string[TrueNum];
            short TrueNick;
            bool Check = false;
            for (int i = 0; i < NickName.Length; i++)
            {
                Console.WriteLine("Введите питомца {0}", i + 1);
                do
                {
                    NickName[i] = Console.ReadLine();
                    if (short.TryParse(NickName[i], out TrueNick))
                    {
                        Console.WriteLine("Цифры недопустимы! Повторите ввод");
                        Check = true;
                    }
                    else
                    {
                        Check = false;
                    }
                } while (TrueNick > short.MinValue && TrueNick < short.MaxValue && Check == true);
            }
        return NickName;
    }
    public static bool CheckPets()
    {
        bool TrueOrFalse;
        string DoUHavePet;
        Console.WriteLine("У вас есть питомцы? Ответьте да / нет");
        do
        {
            DoUHavePet = Console.ReadLine();
            switch (DoUHavePet)
            {
                case "да":
                    TrueOrFalse = true;
                    return TrueOrFalse;

                case "нет":
                    TrueOrFalse = false;
                    return TrueOrFalse;
                
                default:
                    Console.WriteLine("Введите ответ в формате да / нет !");
                    DoUHavePet = "Continue";
                    break;
            }
        } while (DoUHavePet == "Continue");
        TrueOrFalse = false;
        return TrueOrFalse;
    }

    public static bool CheckNum(in string Number, out byte TrueAge)
    {
        byte.TryParse(Number, out byte TPResult);
        if(TPResult > 0)
        {
            TrueAge = TPResult;
            return false;
        }
        else
        {
            TrueAge = 0;
            Console.WriteLine("Введено неверное значение! Повторите ввод!");
            return true;
        }
        
        
    }
}
