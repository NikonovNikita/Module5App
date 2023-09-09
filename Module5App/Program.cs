using System;
using System.Reflection.Metadata;

class MainClass
{
    static int[] SortArrayDesc(int[] arrayDesc)
    {
        int temp;
        for (int i = 0; i < arrayDesc.Length; i++)
        {
            for (int j = i + 1; j < arrayDesc.Length; j++)
            {
                if (arrayDesc[i] < arrayDesc[j])
                {
                    temp = arrayDesc[j];
                    arrayDesc[j] = arrayDesc[i];
                    arrayDesc[i] = temp;
                }
            }
        }
        Console.WriteLine("Ваш массив, отсортированный в порядке от большего к меньшему:");
        foreach(int readArray in arrayDesc)
        {
            Console.Write(readArray + " ");
        }
        return arrayDesc;
    }
    static int[] SortArrayAsc(int[] arrayAsc)
    {
        int temp;
        for (int i = 0; i < arrayAsc.Length; i++)
        {
            for (int j = i + 1; j < arrayAsc.Length; j++)
            {
                if (arrayAsc[i] > arrayAsc[j])
                {
                    temp = arrayAsc[j];
                    arrayAsc[j] = arrayAsc[i];
                    arrayAsc[i] = temp;
                }
            }
        }
        Console.WriteLine("Ваш массив, отсортированный в порядке от меньшего к большему:");
        foreach (int readArray in arrayAsc)
        {
            Console.Write(readArray + " ");
        }
        return arrayAsc;
    }
    static int[] GetArrayFromConsole(ref int num)
    {
        var result = new int[num];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());

        }

        return result;
    }

    static void SortArray(in int[] arrayToSort, out int[] sorteddesc, out int[] sortedasc )
    {
        sorteddesc = SortArrayDesc(arrayToSort);
        sortedasc = SortArrayAsc(arrayToSort);
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите размерность массива num");
        int ValueOfNum = int.Parse(Console.ReadLine());
        var array = GetArrayFromConsole(ref ValueOfNum);
        SortArray(array, out int[] outsorteddesc, out int[] outsortedasc);
        
    }

    
        
}
