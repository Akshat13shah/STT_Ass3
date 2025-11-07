using System;
using System.Collections;

public class Level2_ArrayList
{
    int x;
    public static void Main(string[] args)
    {
        ArrayList L = new ArrayList();
        L.Add(new Level2_ArrayList());
        L.Add(new Level2_ArrayList());
        for (int i = 0; i < L.Count; i++)
            Console.WriteLine(++((Level2_ArrayList)L[i]).x);
        L[0] = L[1];
        ((Level2_ArrayList)L[0]).x = 202;
        for (int i = 0; i < L.Count; i++)
            Console.WriteLine(((Level2_ArrayList)L[i]).x);
        ((Level2_ArrayList)L[0]).x = 111;
        L.RemoveAt(0);
        Console.WriteLine(L.Count);
        Console.WriteLine(((Level2_ArrayList)L[0]).x);
    }
}
