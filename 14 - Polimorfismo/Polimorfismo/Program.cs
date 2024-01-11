namespace Polimorfismo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Polimorfismo !!!");


        /*
        B b=new B();
        b.m();
        b.ma();
        */

        //polimorfismo
        A b=new B();
        A c=new C();
        b.m();
        c.m();

    }

    public abstract class A{
        public virtual void m()
        {
            Console.WriteLine("A:m()");
        }

        public abstract void ma();
    }

    public class B:A{
        public override void m()
        {
            //base.m();
            Console.WriteLine("B:m()");
        }

        public override void ma()
        {
            Console.WriteLine("B:ma()");
        }
    }

    public class C:A{
        public sealed override void m()
        {
            //base.m();
            Console.WriteLine("C:m()");
        }

        public override void ma()
        {
            Console.WriteLine("C:ma()");
        }
    }

    public sealed class D:C{
        public override void ma()
        {
            Console.WriteLine("D:ma()");
        }
    }


    /*    
    public class E:D{
        public override void ma()
        {
            Console.WriteLine("D:ma()");
        }
    }
    */
}
