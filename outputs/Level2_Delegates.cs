using System;

public class Level2_Delegates
{
    public delegate void mydel();
    public void fun1() { Console.WriteLine("fun1()"); }
    public void fun2() { Console.WriteLine("fun2()"); }

    public static void Main(string[] args)
    {
        Level2_Delegates p = new Level2_Delegates();
        mydel obj1 = new mydel(p.fun1);
        obj1 += new mydel(p.fun2);
        Console.WriteLine("run 1");
        obj1();
        mydel obj2 = new mydel(p.fun2);
        obj2 += new mydel(p.fun1);
        Console.WriteLine("run 2");
        obj2();
        obj2 -= p.fun2;
        Console.WriteLine("run 3");
        obj2();
    }
}
