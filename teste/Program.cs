//Alguns números de 4 algarismos possuem uma característica interessante. Ao se separar esse número em duas partes, somar essas duas partes e elevar esse resultado ao quadrado, encontra-se o número original. Por exemplo, o número 3025:
//30 + 25 = 55       -> 55 * 55 = 3025
//Faça um programa que solicite ao usuário um número de 4 algarismos e chame uma função capaz de verificar se ele possui ou não essa característica:


class Program
{
    static void Main(string[] args)
    {
        int N;

        Console.Write("Digite um número de 4 algarismos: ");
        N = int.Parse(Console.ReadLine());

        if (TestaNum(N))
            Console.WriteLine("O número possui essa característica.");
        else
            Console.WriteLine("O número não possui essa característica.");

            Console.ReadKey();
    }

    static bool TestaNum(int n)
    {
        int P1, P2;

        P1 = n / 100;
        P2 = n % 100;

        if ((P1 + P2) * (P1 + P2) == n)
            return true;
        else
            return false;

    }


}
