﻿using System;
using System.Reflection.Metadata;

class MainClass
{
    static void ShowArray(int[] array, bool IsSort = false)
    {
        var temp = array;
        if (IsSort)
        {
            SortArray(temp);
        }
        foreach(var item in temp)
        {
            Console.WriteLine(item + " ");
        }

    }
    
    static int[] GetArrayFromConsole(int num = 5)
    {
        var result = new int[num];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());

        }

        return result;
    }

    static int[] SortArray(int[] result)
    {
        int temp;
        for (int i = 0; i < result.Length; i++)
        {
            for (int j = i + 1; j < result.Length; j++)
            {
                if (result[i] > result[j])
                {
                    temp = result[j];
                    result[j] = result[i];
                    result[i] = temp;
                }
            }
        }
        foreach (int num in result)
        {
            Console.WriteLine(num);
        }
        return result;
    }
    public static void Main(string[] args)
    {
        var array = GetArrayFromConsole();
        var sortedArray = SortArray(array);
    }

    
        
}
