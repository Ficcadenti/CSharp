namespace Fattoriale;

class Program
{
    static void Main(string[] args)
    {
        int n=20000;
        Console.WriteLine("Fattoriale per grandi numeri!!!");
        Console.WriteLine($"{n}!={Fattoriale(n)}");
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
}
