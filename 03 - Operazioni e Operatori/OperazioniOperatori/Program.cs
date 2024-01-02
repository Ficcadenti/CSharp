namespace OperazioniOperatori;

using System;

class Program
{
    static void Main(string[] args)
    {
        int a=10;
        //assegnazione composta
        a+=3;
        Console.WriteLine("Operazioni ed Operatori!");
        Console.WriteLine($"a={a}");

        Console.WriteLine($"a={a++}");

        Console.WriteLine($"a={++a}");

        //casting implicito
        int b=10;
        double d=16.5d+b;
        Console.WriteLine($"d={d}");
        //casting esplicito
        int c=10+(int)d;
        Console.WriteLine($"c={c}");

        //overflow
        int a1=257;
        byte b1=(byte)a1;
        Console.WriteLine($"b1={b1}");

        //classe Convert
        string str=Convert.ToString(d);
        Console.WriteLine($"str={str}");

    }
}
