using System;

class Program
{
    static void Main()
    {
        int a, sayi;

        string[] b = { "umut", "hazar", "serdar", "arif" };
        string[] c = { "istanbul", "amerika", "ingiltere", "dubai" };
        bool[] d = new bool[4];

        Random rastgele = new Random();

        for (a = 0; a < 4; ++a)
        {
            do
            {
                sayi = rastgele.Next(0, 4);
            }
            while (d[sayi] == true);
            d[sayi] = true;

            Console.WriteLine(b[a] + " = " + c[sayi]);
        }
    }
}
