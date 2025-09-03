namespace At003;

class Program
{
    static void Main(string[] args)
    {
        /*
         O C# captura os dados em formato de cadeia de caracteres, dessa forma,temos que
        converter os dados de caracteres para o tipo de dado desejado como veremos abaixo
        */
        Console.WriteLine("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine()); // o .Parse converte apenas dados que venham de string
        Console.WriteLine("Digite sua idade2: ");
        int idade2 = Convert.ToInt32(Console.ReadLine());
        // o .ToInt32 converte dados de diversos tipos, inclusive string, mas também aceita nulo, é indicado para dados que possam vir nulos ou externos
        Console.WriteLine($"Sua idade é: {idade} e {idade2}");

        // Agora vamos converter dados de ponto flutuante
        Console.WriteLine("Digite sua altura: ");
        float altura = float.Parse("1.80");
        Console.WriteLine("Digite sua altura2: ");
        float altura2 = Convert.ToSingle("1.80"); // Convert.ToSingle é usado para converter para float
        Console.WriteLine($"Sua altura é: {altura} e {altura2}");

        // Agora vamos converter dados do tipo double
        Console.WriteLine("Digite seu peso: ");
        double peso = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite seu peso2: ");
        double peso2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Seu peso é: {peso} e {peso2}");



    }
    
    /*
Ótima pergunta! Em C#, tanto `int.Parse()` quanto `Convert.ToInt32()` servem para transformar uma string em um número inteiro, mas eles têm diferenças sutis e importantes:



### 🧠 Diferenças principais

| Característica               | `int.Parse()`                         | `Convert.ToInt32()`                     |
|-----------------------------|----------------------------------------|-----------------------------------------|
| Tipo de entrada             | Apenas `string`                        | Aceita vários tipos (string, bool, etc.) |
| Valor `null`                | Lança `ArgumentNullException`         | Retorna `0`                             |
| Valor inválido              | Lança `FormatException`               | Também lança `FormatException`          |
| Flexibilidade               | Menos flexível                        | Mais versátil                           |

---

### 🔍 Exemplos práticos

```csharp
string s1 = "123";
string s2 = null;
string s3 = "abc";

// int.Parse
int a = int.Parse(s1); // OK: retorna 123
int b = int.Parse(s2); // ERRO: ArgumentNullException
int c = int.Parse(s3); // ERRO: FormatException

// Convert.ToInt32
int x = Convert.ToInt32(s1); // OK: retorna 123
int y = Convert.ToInt32(s2); // OK: retorna 0
int z = Convert.ToInt32(s3); // ERRO: FormatException
```

---

### ✅ Dica extra

Se quiser evitar exceções, use `int.TryParse()`:

```csharp
int resultado;
bool sucesso = int.TryParse(s3, out resultado);
// sucesso = false, resultado = 0
```

---

Se você estiver lidando com dados que podem vir nulos ou mal formatados (como de arquivos ou formulários), `Convert.ToInt32()` ou `TryParse()` são mais seguros. Mas se você **tem certeza** de que a string é válida, `int.Parse()` é direto e eficiente.

Quer ver isso aplicado em algum cenário específico?

*/


}
