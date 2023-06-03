//Faça um algoritmo que solicite ao usuário o valor do seu salário bruto e calcule e imprima quanto ele irá pagar de INSS.

class Program2
{
    static void Main(string[] args)
    {
        double salarioBruto, INSS;

        Console.Write(" Digite o valor do seu salário bruto: ");
        salarioBruto = double.Parse(Console.ReadLine());

        INSS = salarioBruto * ((double)11/100);
        Console.WriteLine($" O valor do INSS é: R${INSS:0.00}");

        Console.ReadKey();
    }
}
