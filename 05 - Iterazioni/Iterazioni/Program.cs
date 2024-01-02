namespace Iterazioni;

using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Iterazioni !!!");

        int x=0;

        //ciclo while
        while (x<10)
        {
            Console.WriteLine($"{x++}");
        }

        //ciclo do-while
        x=0;
        do{
            Console.WriteLine($"{x++}");
        }while(x>0 && x<10);

        //ciclo for
        for(int y=0;y<10;y++)
        {
            Console.WriteLine($"{y}");
        }

        //break & continue
        x=0;
        while (true)
        {
            Console.WriteLine($"{x++}");
            if(x==5)
            {
                break;
            }
        }

        for(int y=0;y<10;y++)
        {
            if(y==5)
            {
                continue;
            }
            Console.WriteLine($"{y}");
        }
    }
}
