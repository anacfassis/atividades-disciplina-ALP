//Faça um programa com 4 variáveis, atribuindo valor a elas e imprimindo na tela os valores resultantes de uma repetição de operações matemáticas entre elas.

class Program4
{
    static void Main(string[] args)
    {
        int a = 1, b = a, c = 2, d = c;

        for (int cont = 1; cont < 5; cont += 2)
        {
            a += b;
            b -= c;
            c += d;
            d -= a;
        }

        Console.WriteLine(a + ", " + b + ", " + c + ", " + d);

        Console.ReadKey();
    }

}