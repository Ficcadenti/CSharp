namespace TestCondizionali;

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Test Condizionali !!!");
        int temperatura=26;

        //if-else
        if(temperatura>25)
        {
            Console.WriteLine("Fa caldo !!!");
        }else if(temperatura<15)
        {
            Console.WriteLine("Fa freddo !!!");
        }
        else{
            Console.WriteLine("Si sta bene !!!");
        }

        //operatore ternario ?
        Console.WriteLine((temperatura>25)?"Fa caldo !!!":"Si sta bene !!!");

        //operatori logici
        int x=5,y=10,z=20;
        Console.WriteLine((x>y && y<z));

        Console.WriteLine((x>y || y<z));

        Console.WriteLine(!(x>y));

        switch(temperatura)
        {
            case 10:
            {
                 Console.WriteLine("10");
            }break;

            case 20:
            {
                 Console.WriteLine("20");
            }break;

            case 30:
            {
                 Console.WriteLine("30");
            }break;

            default:
            {
                Console.WriteLine($"{temperatura}");
            }
            break;
                
       
        }
    }
}
