using System;
using System.Reflection.Metadata;

class MainClass
{
    public static void Main(string[] args)
    {
        var arr = new int[] { 1, 2, 3 };
        BigDataOperation(arr);
        Console.WriteLine(arr[0]);
        Console.WriteLine(arr[1]);
        Console.WriteLine(arr[2]);
    }
    static void BigDataOperation(in int[] arr)
    {
        arr[0] = 4;
        arr[1] = 44;
        arr[2] = 444;
    }

}