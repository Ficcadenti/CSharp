namespace TypeSystem;

using System;

class Program
{
    static void Main(string[] args)
    {

    
        Console.WriteLine("##### Tipi interi ######");
        //value type
        byte b=1; //8 bit, senza segno
        int i=2; //32 bit, con segno
        short s=3; //16 bit, con segno
        long l=4; //64 bit, con segno

        sbyte sb=5; //8 bit, con segno
        uint ui=6; //32 bit, senza segno
        ushort us=7; //16 bit, senza segno
        ulong ul=8; //64 bit, senza segno

        int xb=0b111; //binario
        int xh=0xAFF1; //esadecimale

        int a=1_000_000;

        char c='A';

        Console.WriteLine(b);
        Console.WriteLine(i);
        Console.WriteLine(s);
        Console.WriteLine(l);

        Console.WriteLine(sb);
        Console.WriteLine(ui);
        Console.WriteLine(us);
        Console.WriteLine(ul);

        Console.WriteLine(xb);
        Console.WriteLine(xh);

        Console.WriteLine(a);

        Console.WriteLine(c);

        Console.WriteLine("b={0},i={1}",b,i);
        Console.WriteLine($"b={b},i={i}");

        Console.WriteLine("##### Tipi decimali ######");
        //Standard iEEE 754
        float f=32.54f; //32 bit; con segno
        double d=64.54d; //64 bit, con sego:
        decimal dc=128.8m; //128 bit, con segno
        Console.WriteLine($"f={f} d={d} decimal={dc}" );

        double x=1.4e6;
        double y=1.4e-6;
        Console.WriteLine($"x={x}, y={y}");

        Console.WriteLine("##### Tipo booleano ######");
        bool bl=true; //8 bit;
        Console.WriteLine($"bl={bl}");

         Console.WriteLine("##### Tipo stringa ######");
         //reference type
         string str="Ciao mondo";
         Console.WriteLine($"str={str}");

         Console.WriteLine("##### Inferenza di tipo ######");
         var x1=10;
         var b1=true;
         var c2=5.7f;
         var str1="Megaloman...";

         Console.WriteLine($"x1={x1} b1={b1} c2={c2} str1={str1}");



    }
}
