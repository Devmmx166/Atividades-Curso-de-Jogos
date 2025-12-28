namespace AT01; //name space é o nome do projeto

class Program //program é a casse
{
    static void Main(string[] args) //main é o método principal
    {
//        // Tipos de variáveis em C#
//         int idade = 25; //variável do tipo inteiro
//         string nome = "João"; //variável do tipo string / literal de texto
//         char letra = 'A'; //variável do tipo char / literal de apenas caractere
//         float altura = 1.75f; //variável do tipo real / número com casa decimal quando inserido manual tem que por f no fim do numero.
//         double peso = 70.5; //variável do tipo double / número com casa decimal porem mais preciso e suporta mais casas decimais  que float
//         bool estudante = true; //variável do tipo boolean / só aceita true ou false/ verdadeiro ou falso/ sim ou não / 0 ou 1

//         // Exibir informações no console ou na tela "Console.WriteLine()"
//         Console.WriteLine("Nome: " + nome);
//         Console.WriteLine("Idade: " + idade);
//         Console.WriteLine("Letra: " + letra);
//         Console.WriteLine("Altura: " + altura);
//         Console.WriteLine("Peso: " + peso);
//         Console.WriteLine("Estudante: " + estudante);

//         //Inserir um dado via console "Console.ReadLine()"
//         Console.Write("Digite seu nome: "); //exibe a mensagem no console
//         string nomeUsuario = Console.ReadLine(); //lê o dado inserido pelo usuário e armazena na variável nomeUsuario   
//         Console.WriteLine("Olá, " + nomeUsuario + "! Bem-vindo ao C#.");

//         /* todos os dados inseridos via console são do tipo string
//            tem a que converter para outros tipos se necessário        
//         */

//         Console.Write("Digite sua idade: ");
//         int idadePessoa = Convert.ToInt32(Console.ReadLine()); //converte o dado inserido para inteiro, mais usado quando recebe dados do sistema
//         int idadePessoa02 = int.Parse(Console.ReadLine());//converte o dado inserido para inteiro
//         /*
//         🧠 Dica prática

// Use int.Parse() quando tem certeza de que a string não é nula e contém um número válido.

// Use Convert.ToInt32() quando o valor pode ser nulo ou vir de fontes variadas (ex: objetos, banco de dados, campos de formulário).
//         */

//         // Valores Reais

//         //exemplo 1 de conversão para número decimal
//         float peso01 = float.Parse(Console.ReadLine());
//         //exemplo 2 de conversão para número decimal
//         double peso02 = Convert.ToDouble(Console.ReadLine());

//         //(Dependendo da cultura do sistema, o separador decimal pode ser , ou .)

//         //Cuidados importantes

//         /*Se o usuário digitar algo inválido (ex: "abc"), o código lança uma FormatException.

//         Se o usuário apenas apertar Enter (string vazia), também dá exceção.

//         Se o usuário digitar nada (null), Convert.ToDouble(null) retorna 0.0.

//         💡 Alternativa mais segura

//         Se quiser evitar exceções quando o usuário digitar algo inválido, use double.TryParse():
//         */
//         //TryParse() retorna true se a conversão deu certo, e false se não deu — sem lançar exceção.


//         /*Podemos um converter número para string basta colocar depois da variável o comando .ToString(). //exemplo de conversão para string  */
//         int nomeVariavel = 100;
//         string variavel = nomeVariavel.ToString();
//         Console.WriteLine(variavel);

    //Modulo ou resto da divisão %

    int soma = 5+5;
    int subtracao = 5-2;
    int multiplicacao = 5*3;
    int divisao = 15 /3;

    Console.WriteLine("Soma: "+ soma);
    Console.WriteLine("Subtração: " + subtracao);
    Console.WriteLine("Multiplicação: "+ multiplicacao);
    Console.WriteLine("Divisão: "+ divisao);



    
}
}
