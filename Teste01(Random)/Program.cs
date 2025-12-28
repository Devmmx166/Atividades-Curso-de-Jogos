namespace Teste01_Random_;

class Program
{
    static void Main(string[] args)
    {
 
      Random random = new Random();

      int roll01 = random.Next(100);// se colocar um valor dentro das parenteses do neste cria uma limitação ex. Next(100) vai de 0 a 99
      int roll02 = random.Next(1,101);
      int roll03 = random.Next(1,101);
      int roll04 = random.Next(1,101);//  vai de 1 a 100


      

      Console.WriteLine($"Resultado:({roll01}) ({roll02}) ({roll03}) ({roll04})");
    
      // Console.WriteLine(roll);
      // Console.WriteLine(roll);
      // Console.WriteLine(roll);

    }
}
