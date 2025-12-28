namespace AT12;

class Program
{
    static void Main(string[] args)
    {
       Random random = new Random();

       int roll = random.Next(0, 101);
       Console.WriteLine($"Numero sorteado é:({roll})");
    }
}
