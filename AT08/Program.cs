namespace AT08;

class Program
{
    static void Main(string[] args)
    {
       float porcentagem = 12;
       Console.WriteLine("Valor de desconto.");

       Console.Write("Informe o valor do produto: ");
       float produto = float.Parse(Console.ReadLine());
       
    //    float desconto = (porcentagem /100)*produto; //formula padrão

       float desconto =  produto * 1.12f; //simples

      
      Console.WriteLine($"Valor com desconto {desconto}");
    }
}
