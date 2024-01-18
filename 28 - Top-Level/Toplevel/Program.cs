using System;
using System.Diagnostics.Contracts;

Console.WriteLine("Top-Level statements !!!");
foreach(string a in args)
{
    Console.WriteLine($"Arg: {a}");
}

var instance=new MyClass{
    MyProp="Raffaele"
};
//instance.MyProp="Sofia"; //ERRORE
instance.show();


public class MyClass
{
    public string? MyProp {get;init;}

    public void show()
    {
        Console.WriteLine($"MyProp={this.MyProp}");
    }
}
