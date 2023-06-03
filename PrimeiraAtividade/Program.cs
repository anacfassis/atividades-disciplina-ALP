//Faça um algoritmo que calcule e imprima o valor da hipotenusa de um triângulo retângulo, sendo dados os valores dos catetos pelo usuário.

class Program
{
    static void Main(string[] args)
    {
        int cateto1, cateto2;
        double hipotenusa;

        Console.Write("Digite o valor do primeiro cateto: ");
        cateto1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor do segundo cateto: ");
        cateto2 = int.Parse(Console.ReadLine());

        hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));
        Console.WriteLine("O valor da hipotenusa é: " + hipotenusa);

        Console.ReadKey();
   }
}