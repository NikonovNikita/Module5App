using System;
using System.Reflection.Metadata;

class MainClass
{
    public static void Main(string[] args)
    {
        GetArrayFromConsole();
        SortArray();
    }

    static int[] GetArrayFromConsole()
    {
        var result = new int[3];
        
        for(int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());

        }

        return result;
    }

    static int[] SortArray(int[] result)
    {
        int temp;
        for(int i = 0; i < result.Length; i++)
        {
            for(int j = i + 1; j < result.Length; j++)
            {
                if (result[i] > result[j])
                {
                    temp = result[j];
                    result[j] = result[i];
                    result[i] = temp;
                }
            }
        }
        
        return result;
    }
        
}
