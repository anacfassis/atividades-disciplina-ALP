//Faça um programa que solicite ao usuário digitar o número do mês e imprima o nome dp mês por extenso, utilizando switch case. Após, imprima quantos dias tem o mês digitado, utilizando switch case.

class Program3
{
    static void Main(string[] args)
        {
        int mes;

        Console.Write("Digite o número do mês: ");
        mes = int.Parse(Console.ReadLine());
        string nomeMes;

         switch (mes)
        {
            case 1:
                nomeMes = "Janeiro";
                break;
            case 2:
                nomeMes = "Fevereiro";
                break;
            case 3:
                nomeMes = "Março";
                break;
            case 4:
                nomeMes = "Abril";
                break;
            case 5:
                nomeMes = "Maio";
                break;
            case 6:
                nomeMes = "Junho";
                break;
            case 7:
                nomeMes = "Julho";
                break;
            case 8:
                nomeMes = "Agosto";
                break;
            case 9:
                nomeMes = "Setembro";
                break;
            case 10:
                nomeMes = "Outubro";
                break;
            case 11:
                nomeMes = "Novembro";
                break;
            case 12:
                nomeMes = "Dezembro";
                break;
            default:
                nomeMes = "Mês inválido";
                break;
        }

        Console.WriteLine($"O mês digitado foi {nomeMes}.");

        switch (nomeMes)
        {
            case "Janeiro":
            case "Março":
            case "Maio":
            case "Julho":
            case "Agosto":
            case "Outubro":
            case "Dezembro":
                Console.WriteLine("O mês tem 31 dias.");
                break;
            case "Fevereiro":
                Console.WriteLine("O mês tem 28 ou 29 dias.");
                break;
            default:
                Console.WriteLine("O mês tem 30 dias.");
                break;
        }

        Console.ReadKey();
    }

}