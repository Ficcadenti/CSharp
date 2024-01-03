namespace Metodi;

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Metodi !!!");
        Console.WriteLine($"{Program.somma(10,20)}");
        Console.WriteLine($"{Program.somma(10.1d,20.1d)}");
        Console.Write("Clcola il fattoriale di: ");
        int n=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Il fattoriale di {n} è {Program.fattoriale(n)}");

    }

    static int somma(int a,int b)
    {
        int s=a+b;
        return s;
    }

    static double somma(double a,double b)
    {
        double s=a+b;
        return s;
    }

    static int fattoriale(int n)
    {
        if(n==0)
        {
            return 1;
        }else{
            return n*fattoriale(n-1);
        }
    }

}
