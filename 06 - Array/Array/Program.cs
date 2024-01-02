namespace Array;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Array !!!");

        //array
        int[] arr=new int[10];
        int[] x=new []{1,2,3,4,5,6,7,8,9,0};
        string[] s=new string[10];

        arr[2]=50;
        s[1]="Ciao";

        Console.WriteLine(arr[2]);
        Console.WriteLine(s[1]);
        Console.WriteLine(x[3]);
        Console.WriteLine(s[0]);

        //jagged array
        int[][] a=new int [3][];
        a[0]=new []{0,1,2};
        a[1]=new []{10,11,12,13,14};
        a[2]=new []{-4,5};

        int[][] a1={
            new []{0,1,2},
            new []{10,11,12,13,14},
            new []{-4,5}
        };

        Console.WriteLine(a1[1][1]);

        //array multidimensionale
        int[,] b=new int[3,3];

        int[,] b1={
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };

        Console.WriteLine(b1[1,1]);

        //ciclo for-each
        Console.WriteLine("Ciclo for-each");
        foreach(int[] v in a1)
        {
            foreach(int v1 in v)
            {
                Console.WriteLine(v1);
            }
        }

        Console.WriteLine($"Lunghezza : {arr.Length}");

        for(int i=0;i<arr.Length;i++)
        {
            Console.WriteLine($"{arr[i]}");
        }

        int[,] m=new int[5,5];
        int counter=0;
        for(int r=0;r<5;r++)
        {
            for(int c=0;c<5;c++)
            {
                ++counter;
                m[r,c]=c==0?0:counter;
            }
        }

        for(int r=0;r<5;r++)
        {
            for(int c=0;c<5;c++)
            {
                Console.Write($"{m[r,c]} ");
            }
            Console.Write("\n");
        }


    }
}
