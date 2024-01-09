using System;

namespace Esercitazione
{

    class Esercitazione
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("Esercitazione !!!");

            MyStruct ms=new MyStruct();
            ms.myInt=10;
            ms.myString="Raffo";

            MyClass mc=new MyClass();
            mc.myInt=20;
            mc.myString="Valeria";

            Console.WriteLine(ms);
            Console.WriteLine(mc);


            //passaggio di parametri per valore o per riferimento
            CLassMethod(ms,mc,100,"Gabriele");

            Console.WriteLine(ms);
            Console.WriteLine(mc);



        }

        static void CLassMethod(MyStruct ms, MyClass mc, int i, string s)
        {
            ms.myInt=i;
            ms.myString=s;
            mc.myInt=i;
            mc.myString=s;
        }
    }

    public struct MyStruct
    {
        public int myInt;
        public string myString;

        public override string ToString()
        {
            return "MyStruct: " + myInt + " " + myString;
        }
    }

    public class MyClass
    {
        public int myInt{get;set;}
        public string? myString{get;set;}

        public override string ToString()
        {
            return "MyClass: " + myInt + " " + myString;
        }
    }
}