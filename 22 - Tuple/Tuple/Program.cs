using System.Drawing;
using System.Reflection.Metadata;

namespace Tuple{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Le tuple!");

            var myColor = (255,134,0,"green");


            //tupla unnamed
            Console.WriteLine($"myColor={myColor}");
            Console.WriteLine($"myColor={myColor.Item1}");
            Console.WriteLine($"myColor={myColor.Item2}");

            //tupla named
            var myColor2 = (red:255,green:134,blue:0,name:"green");
            Console.WriteLine($"myColor2={myColor2}");
            Console.WriteLine($"myColor2={myColor2.red}");
            Console.WriteLine($"myColor2={myColor2.name}");

            //tupla proiettata
            int red=255;
            int green=255;
            int blue=0;
            string name="ocra";
            var myColor3 = (red,green,blue,name);
            Console.WriteLine($"myColor3={myColor3}");
            Console.WriteLine($"myColor3={myColor3.red}");
            Console.WriteLine($"myColor3={myColor3.name}");

            (int, int ,int) color1=color("Ocra");
            Console.WriteLine($"color1={color1}");
            Console.WriteLine($"color1={color1.Item1}");
            Console.WriteLine($"color1={color1.Item2}");
            Console.WriteLine($"color1={color1.Item3}");

            (int r, int g ,int b) color2=color("Ocra");
            Console.WriteLine($"color2={color2}");
            Console.WriteLine($"color2={color2.r}");
            Console.WriteLine($"color2={color2.g}");
            Console.WriteLine($"color2={color2.b}");

            (int r, int g ,int b) = color("Ocra");
            Console.WriteLine($"r={r}");
            Console.WriteLine($"g={g}");
            Console.WriteLine($"h={b}");
            
            var (r1,g1,b1)=color("Ocra");
            Console.WriteLine($"r1={r1}");
            Console.WriteLine($"g1={g1}");
            Console.WriteLine($"b1={b1}");        
            }

        static (int,int,int) color(string name)
        {
            if(name.Equals("ocra",StringComparison.InvariantCultureIgnoreCase))
                return (255,191,0);
            else
                return (-1,-1,-1);
        }
    }
}
