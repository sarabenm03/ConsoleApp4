using System;

namespace ConsoleApp4
class NombrePremier
{

    static void Main()
    {
        int[] diviseurs = { 2, 3, 5, 7 };
        int i = 10, j;


        while (i <= 2000)
        {

            for (j = 0; j <= 3; j++)
            {
                if (i % diviseurs[j] == 0) i++;
                else if (j == 3)
                {
                    Console.WriteLine(i + " est premier");
                    i++;
                }
            }
        }
    }
}
