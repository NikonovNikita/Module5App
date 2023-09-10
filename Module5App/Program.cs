using System;
using System.Reflection.Metadata;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(PowerUp(2, 3));
    }
    static int PowerUp (int N, byte pow)
    {
        if(pow == 0)
        {
            return 1;
        }
        else
        {
            if(pow == 1)
            {
                return N;
            }
            else
            {
                return N * PowerUp(N, --pow);
            }
        }
    }
    

}