using System.IO.Pipes;

namespace AT03;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Informe sua idade");
       int idade = int.Parse(Console.ReadLine());
       int ano = 365;
       
       int idadeEmDias = ano * idade;     

       Console.WriteLine("Sua idade em dia é :" + idadeEmDias+" dias de vida!");

    }
}
