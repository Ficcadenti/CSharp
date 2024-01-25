namespace Fattoriale;

class Program
{
    static void Main(string[] args)
    {
        int n=200;
        Console.WriteLine("Fattoriale per grandi numeri !!!");
        Console.WriteLine($"{n}!={Fattoriale(n)}");


        Console.WriteLine("Duplicati in array !!!");
        int Min = 1,Max = 10;
        int[] test = new int[10];
        
        for (int i = 0; i < test.Length; i++)
        {
            test[i] = GetRandomInt(Min, Max);
        }

        StampaArray(test);

        var dict = new Dictionary<int, int>();

        foreach(var t in test)
        {
            dict.TryGetValue(t, out int count);
            dict[t] = count + 1;
        }
        
        foreach(var v in dict)
        {
            Console.WriteLine($"Il umero {v.Key} è presente {v.Value} volte.");
        }
    }


    static string Fattoriale(int n)
    {
        if (n == 0 || n == 1)
        {
            return "1";
        }

        string res = "1";

        for (int i = 2; i <= n; i++)
        {
            res = Moltiplica(res, i.ToString());
        }

        return res;
    }

    static string Moltiplica(string num1, string num2)
    {
        int len1 = num1.Length;
        int len2 = num2.Length;
        int[] res = new int[len1 + len2];

        for (int i = len1 - 1; i >= 0; i--)
        {
            for (int j = len2 - 1; j >= 0; j--)
            {
                int m = (num1[i] - '0') * (num2[j] - '0');
                int s = m + res[i + j + 1];

                res[i + j] += s / 10;
                res[i + j + 1] = s % 10;
            }
        }

        string resultStr = string.Join("", res).TrimStart('0');

        return string.IsNullOrEmpty(resultStr) ? "0" : resultStr;
    }

    static int GetRandomInt(int minVal, int maxVal)
        {
            return new Random().Next(minVal, maxVal);
        }

        static void StampaArray(int[] arr)
        {
            foreach (int n in arr)
            {
                Console.Write($"{n} ");
            }
            Console.WriteLine();
        }
}
