namespace Modificatori{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Modificatori ref, out, in !!!");
            int x=5;
            Console.WriteLine($"x={x}");
            MyFunc(x);
            Console.WriteLine($"x={x}");

            MyFuncRef(ref x);
            Console.WriteLine($"x={x}");

            MyClass c=new MyClass();
            Console.WriteLine($"c.x={c.x}");
            MyMethod(c);
            Console.WriteLine($"c.x={c.x}");
            MyMethod1(c);
            Console.WriteLine($"c.x={c.x}");
            MyMethod2(ref c);
            Console.WriteLine($"c.x={c.x}");

            int k=5;
            MyClass mc=new MyClass();
            Console.WriteLine($"mc.x={mc.x} k={k}");
            MyFunc(ref mc,ref k);
            Console.WriteLine($"mc.x={mc.x} k={k}");
            MyFuncIn(mc,k);
            Console.WriteLine($"mc.x={mc.x} k={k}");

            MyFuncOut(out MyClass mcc, out int kk);
            Console.WriteLine($"mcc.x={mcc.x} kk={kk}");

        }

        static void MyFuncOut(out MyClass y,out int k)
        {
            y=new MyClass();
            y.x=10000;
            k=1000;
        }

        static void MyFuncIn(in MyClass y,in int k)
        {
            //y=new MyClass();
            y.x=1000000;
            //k=1000;
        }

        static void MyFunc(int val)
        {
            val=10;
        }

        static void MyFunc(ref MyClass y, ref int k)
        {
            y.x=10;
            k=10;
        }

        static void MyFuncRef(ref int val)
        {
            val=10;
        }
        static void MyMethod(MyClass c)
        {
            c.x=20;
        }

        static void MyMethod1(MyClass c)
        {
            c=new MyClass();
            c.x=2000;
        }

        static void MyMethod2(ref MyClass c)
        {
            c=new MyClass();
            c.x=2000;
        }


        public class MyClass
        {
            public int x=5;
        }
    }
}
