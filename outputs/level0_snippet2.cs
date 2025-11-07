using System;

class Level0_Snippet2
{
    int age;
    // constructor as expression-bodied
    Level0_Snippet2() => age = age == 0 ? age + 1 : age - 1;

    static void Main()
    {
        int k = "010%".Replace('0', '%').Length; // result "%1%%" length=4
        Console.Write("[" + (k << ++new Level0_Snippet2().age).ToString() + "]");
        Console.Write("[" + "010%".Split('1')[1][0] + "]");
        Console.Write("[" + "010%".Split('0')[1][0] + "]");
        Console.Write("[" + int.Parse(Convert.ToString("123".ToCharArray()[~-1])) + "]");
    }
}
