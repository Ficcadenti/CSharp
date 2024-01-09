namespace Ereditarieta;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ereditarietà !!!");
        BClass b=new BClass();
        //b.aVar=10; ERRORE se aVar è protected
        b.bVar=20;

        Console.WriteLine(b);

        AClass a=new BClass();
        a.aVar=10;
        Console.WriteLine(a);

        if(a is BClass)
        {
            BClass b1=(BClass) a;
            b1.bVar=100;
            Console.WriteLine(b1);
        }


        BClass? b2=a as BClass;
        if(b2 !=null)
        {
            b2.bVar=200;
            Console.WriteLine(b2);
        }else{
             Console.WriteLine("Cast impossibile !!!");
        }
    }

    //superclasse o base
    public class AClass
    {
        public int aVar;

        public override string ToString()
        {
            return $"AClass : aVar{aVar}";
        }
    }

    //classe derivate
    public class BClass: AClass
    {
        public int bVar;

        public override string ToString()
        {
            return $"BClass : aVar={aVar} bVar={bVar}";
        }
    }
}
