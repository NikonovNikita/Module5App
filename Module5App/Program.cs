using System;
using System.Reflection.Metadata;

class MainClass
{
    static int[] GetArrayFromConsole()
    {
        var result = new int[5];

        for(int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }

        int temp;
        for (int i = 0; i < result.Length; i++)
        {
            for (int j = i + 1; j < result.Length; j++)
            {
                if (result[j] < result[i])
                {
                    temp = result[j];
                    result[j] = result[i];
                    result[i] = temp;
                }
            }
        }
        
        for(int k = 0; k < result.Length; k++)
        {
            Console.WriteLine(result[k]);
        }
        
        return result;
    }
   

    public static void Main(string[] args)
    {
        GetArrayFromConsole();
    }
}