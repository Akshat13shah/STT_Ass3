using System;

public class A
{
    public virtual void f1()
    {
        Console.WriteLine("f1");
    }
}

public class B : A
{
    public override void f1() => Console.WriteLine("f2");
}

class Level1_Snippet3
{
    static int i = 0;
    public event FuncPtr handler;
    public delegate void FuncPtr();
    public void destroy()
    {
        if (i == 6) return;
        else
        {
            Console.WriteLine(i++);
            destroy();
        }
    }
    public static void Main(string[] args)
    {
        Level1_Snippet3 p = new Level1_Snippet3();
        p.handler += new FuncPtr((new A()).f1);
        p.handler += new FuncPtr((new B()).f1);
        p.handler();

        p.handler -= new FuncPtr((new B()).f1);
        p.handler -= new FuncPtr((new A()).f1);

        p?.destroy();
        p = null;
        i = -6;
        p?.destroy();
        (new Level1_Snippet3())?.destroy();
    }
}
