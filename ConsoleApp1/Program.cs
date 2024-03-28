using System;

class Test
{
    public static void Main()
    {
        int i, j, so_hang;
        Console.Write("\n");
        Console.Write("Ve tam giac sao can trong C#:\n");
        Console.Write("-------------------------");
        Console.Write("\n\n");

        Console.Write("Nhap so hang: ");
        so_hang = Convert.ToInt32(Console.ReadLine());
        for (i = 0; i <= so_hang; i++)
        {
            for (j = 1; j <= so_hang - i; j++)
                Console.Write(" ");
            for (j = 1; j <= 2 * i - 1; j++)
                Console.Write("{0}",j);
            Console.Write("\n");
        }

        //Console.ReadKey();

        //int i, j, so_hang;
        //Console.Write("\n");
        //Console.Write("Ve tam giac sao vuong lon trong C#:\n");
        //Console.Write("-------------------------");
        //Console.Write("\n\n");

        //Console.Write("Nhap so hang: ");
        //so_hang = Convert.ToInt32(Console.ReadLine());
        //for (i = 0; i <= so_hang; i++)
        //{
        //    for (j = 1; j <= so_hang - i; j++)
        //        Console.Write("*");
        //    Console.Write("\n");
        //}

        //Console.ReadKey();

        //int i, j, so_hang;
        //Console.Write("\n");
        //Console.Write("Ve tam giac sao vuong trong C#:\n");
        //Console.Write("-------------------------");
        //Console.Write("\n\n");

        //Console.Write("Nhap so hang: ");
        //so_hang = Convert.ToInt32(Console.ReadLine());
        //for (i = 0; i <= so_hang; i++)
        //{
        //    for (j = 1; j <= i; j++)
        //        Console.Write("*");
        //    Console.Write("\n");
        //}

        //Console.ReadKey();
    }
}