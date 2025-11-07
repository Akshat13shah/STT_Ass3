using System;

class Level1_Snippet2
{
    int f;
    public static void Main(string[] args)
    {
        Console.WriteLine("run 1");
        Level1_Snippet2 p = new Level1_Snippet2(new int() + "0".Length);
        for (int i = 0, _ = i; i < 5 && ++p.f >= 0; i++, Console.WriteLine(p.f++)) ;
        {
            for (; p.f == 0;) ;
            {
                Console.WriteLine(p.f);
            }
        }
        Console.WriteLine("\nrun 2");
        p = new Level1_Snippet2(p.f);
        Console.WriteLine(p.f);
        Console.WriteLine("\nrun 3");
        p = new Level1_Snippet2();
        Console.WriteLine(p.f);
    }
    Level1_Snippet2() => f = 0;
    Level1_Snippet2(int x) => f = x;
}
