namespace Interfaccie;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Interfaccie  !!!");

        A a =new A();
        a.m();

    
        XClass.met(a,a);
    }

    public interface IMyInterface1
    {
        void m();

        int xCoord{get;set;}
        
    }

    public interface IMyInterface2
    {
        void m1();

    }

    public class A:IMyInterface1,IMyInterface2
    {
        public void m()
        {
            Console.WriteLine("A:m()");
        }

        public void m1()
        {
            Console.WriteLine("A:m1())");
        }

        public int xCoord{get;set;}
    }

    public class XClass{
        public static void met(IMyInterface1 i1,IMyInterface2 i2)
        {
            i1.m();
            i2.m1();
        }
    }
}
