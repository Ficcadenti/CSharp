using System;

namespace Object{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("La classe Object !!!");

            AClass a=new AClass();
            a.aVar=10;
            Console.WriteLine(a);
            Console.WriteLine(a.GetHashCode());
            AClass a1=new AClass();
            a1.aVar=10;
            Console.WriteLine(a.Equals(a1));


            BClass b=new BClass();
            b.aVar=5;
            b.bVar=10;
            Console.WriteLine(b);
        }
    }

    //superclasse o base
    public class AClass : System.Object //di default o object
    {
        public int aVar;

        public override string? ToString()
        {
            return $"{base.ToString()} -> aVar{aVar}";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(aVar);
        }

        public override bool Equals(object? obj)
        {
            #nullable disable
            if(obj!=null)
                return aVar==(obj as AClass).aVar;
            else return false;
            #nullable enable
        }

    }

    //classe derivate
    public class BClass: AClass
    {
        public int bVar;

        public override string ToString()
        {
            return $"{base.ToString()} -> aVar={aVar} bVar={bVar}";
        }
    }

    //classe derivate
    public class CClass: BClass
    {
        public int cVar;

        public override string ToString()
        {
            return $"{base.ToString()} -> cVar{cVar} bVar={bVar} aVar={aVar}";
        }
    }
}