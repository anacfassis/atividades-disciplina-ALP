﻿class Program5
{
    static void Main(string[] args)
    {
        for (int i = 3; i < 8; i++)
        {
            for (int j = 5; j > 1; j--)
            {
                Console.WriteLine($"{i} - {j}");
                i++;
            }

            Console.ReadKey();
        }
    }
}
