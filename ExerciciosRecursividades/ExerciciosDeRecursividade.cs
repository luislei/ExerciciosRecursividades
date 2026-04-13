
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

/// 📖 O QUE É RECURSIVIDADE?   
/// /// ========================   
/// /// Recursividade é uma técnica de programação onde uma função/método  
///  /// chama a si mesma para resolver um problema.   
/// ///   
/// /// 🧠 CONCEITOS FUNDAMENTAIS:   
/// /// 1. CASO BASE (Condição de parada): É a condição que interrompe as   
/// ///    chamadas recursivas, evitando loop infinito.   ///   
/// /// 2. CASO RECURSIVO: É onde a função chama a si mesma com um   
/// ///    parâmetro modificado (geralmente menor).   ///   
/// /// 3. PILHA DE CHAMADAS (Call Stack): Cada chamada recursiva é   
/// ///    empilhada na memória até atingir o caso base.   ///   
/// /// 💡 Analogia da vida real:   /// Imagine uma boneca russa (Matryoshka) - para chegar na boneca  
/// /// menor, você precisa abrir a maior, depois a média, até chegar   
/// /// na mais interna. Para voltar, você vai fechando cada uma.   /// 
/// /// ⚠️ CUIDADOS:   /// - Sem caso base = loop infinito (StackOverflow)   
/// /// - Muitas chamadas recursivas = estouro de pilha   
/// /// - Recursão é mais intuitiva mas pode ser mais lenta que iteração
namespace ExerciciosAula02B;

  /// <summary>
  /// 🔄 EXERCÍCIOS DE RECURSIVIDADE
  /// ===============================
  ///
  /// Exercício 1: Fatorial Simulado (Recursivo)
  /// Exercício 2: Sequência de Fibonacci (Recursivo)
  /// Exercício 3: Verificador de Palíndromo (Recursivo)
  /// </summary>
  public class AlunoRecursividade
    {
    public void Executar()
    {
      Console.WriteLine("\n\n🔄 1. EXERCÍCIOS DE RECURSIVIDADE");
      Console.WriteLine("==================================\n");

      // ===================================================
      // EXERCÍCIO 5: Fatorial Simulado (Recursivo)
      // ===================================================
      // 👉 O QUE FAZER:
      // 1. Solicitar ao usuário que digite um número inteiro positivo
      // 2. Criar um método recursivo que calcule o fatorial (n!)
      // 3. Fórmula: n! = n * (n-1) * (n-2) * ... * 1
      // 4. Caso base: se n = 0 ou n = 1, retornar 1
      // 5. Caso recursivo: n * Fatorial(n - 1)
      // 6. Exibir o resultado do fatorial
      // 7. Tratar números negativos (exibir mensagem de erro)
      //
      // 💡 Exemplo: 5! = 5 * 4 * 3 * 2 * 1 = 120

      Console.WriteLine("📝 Exercício 2: Fatorial Recursivo");

      // ESCREVA SEU CÓDIGO AQUI

        Console.Write("Digite um número inteiro positivo: ");
        
        // ler a entrada e converter para inteiro
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            // verifica se o numero é positivo
            if (numero < 0)
            {
                Console.WriteLine("Erro: O número tem de ser positivo.");
            }
            else
            {
                // calcula o fatorial com a função recursiva
                long resultado = Fatorial(numero);
                Console.WriteLine($"{numero}! = {resultado}");
            }
        }
        else
        {
            Console.WriteLine("Erro: Entrada inválida. Por favor, digite um número inteiro.");
        }

        /// Método recursivo para calcular o fatorial de um número.
        
        static long Fatorial(int n)
        {
            // 4. Caso base: se n = 0 ou n = 1, retornar 1
            if (n == 0 || n == 1)
            {
                return 1;
            }

            // 5. Caso recursivo: n * Fatorial(n - 1)
            return n * Fatorial(n - 1);
        }

      // Saída esperada:
      /**📝 Exercício 2: Fatorial Recursivo
      Digite um número para calcular o fatorial: 5
      5! = 120
     
      Digite um número para calcular o fatorial: -3
      Erro: Não é possível calcular fatorial de número negativo!
      */
      Console.WriteLine();

      // ===================================================
      // EXERCÍCIO 3: Sequência de Fibonacci (Recursivo)
      // ===================================================
      // 👉 O QUE FAZER:
      // 1. Solicitar ao usuário que digite a posição desejada da sequência
      // 2. Criar um método recursivo que retorne o número na posição informada
      // 3. Fórmula: Fibonacci(n) = Fibonacci(n-1) + Fibonacci(n-2)
      // 4. Caso base: se n = 0, retornar 0; se n = 1, retornar 1
      // 5. Caso recursivo: Fibonacci(n-1) + Fibonacci(n-2)
      // 6. Exibir o valor na posição solicitada
      // 7. Exibir toda a sequência até essa posição
      // 8. Tratar posições negativas
      //
      // 💡 Sequência: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...
      // 💡 Posição 0 → 0, Posição 1 → 1, Posição 2 → 1, Posição 3 → 2

      Console.WriteLine("\n📝 Exercício 6: Sequência de Fibonacci (Recursivo)");

      // ESCREVA SEU CÓDIGO AQUI

        Console.WriteLine("Digite a posição desejada na sequecia de Fibonacci:");
        if (int.TryParse(Console.ReadLine(), out int posicao))
        {
            if (posicao < 0)
                {
                    Console.WriteLine("Erro: a posição deve ser um numero inteiro");
                }
            else
            {
                Console.WriteLine("O resultado \n");
                Console.WriteLine($"sequencia ate à posição {posicao}");
                for (int i=0; i<=posicao;i++)
                    {
                        Console.WriteLine(Fibonacci(i) + (i ==posicao ? "":","));
                    }

                    // mostrar o valor na posição solicitada
                    long valorFinal = Fibonacci(posicao);
                    Console.WriteLine($"o valor na posição {posicao} é: {valorFinal}");
            }
        }

        else
        {
            Console.WriteLine("Erro: Entrada inválida. Por favor, digite um número inteiro.");
        }

    /// Método recursivo para calcular o número de Fibonacci em uma posição n.

    static long Fibonacci(int n)
    {
        // 4. Caso base: se n = 0, retornar 0; se n = 1, retornar 1
        if (n == 0) return 0;
        if (n == 1) return 1;

        // 5. Caso recursivo: Fibonacci(n-1) + Fibonacci(n-2)
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

      // Saída esperada:
      /**📝 Exercício 3: Sequência de Fibonacci (Recursivo)
      Digite a posição desejada da sequência: 7
      O valor na posição 7 da sequência é: 13
     
      Sequência completa até a posição 7:
      Posição 0: 0
      Posição 1: 1
      Posição 2: 1
      Posição 3: 2
      Posição 4: 3
      Posição 5: 5
      Posição 6: 8
      Posição 7: 13
      */
      Console.WriteLine();

      // ===================================================
      // EXERCÍCIO 4: Verificador de Palíndromo (Recursivo)
      // ===================================================
      // 👉 O QUE FAZER:
      // 1. Solicitar ao usuário que digite uma palavra ou frase
      // 2. Remover espaços e converter para minúsculo (ou maiúsculo)
      // 3. Criar um método recursivo que verifica se a string é um palíndromo
      // 4. Palíndromo: palavra/frase que se lê igual de trás pra frente
      // 5. Caso base: se string tem 0 ou 1 caractere, retornar true
      // 6. Caso base: se primeiro e último caracteres são diferentes, retornar false
      // 7. Caso recursivo: verificar substring sem primeiro e último caracteres
      // 8. Exibir se a palavra/frase é ou não um palíndromo
      // 9. Ignorar acentos e caracteres especiais (opcional)
      //
      // 💡 Exemplos: "radar", "reviver", "socorram me subi no onibus em marrocos"
      // 💡 "A man, a plan, a canal: panama"

      Console.WriteLine("\n📝 Exercício 7: Verificador de Palíndromo (Recursivo)");

      // ESCREVA SEU CÓDIGO AQUI
        // 1. Solicitar ao usuário que digite uma palavra ou frase
        Console.WriteLine("Digite uma palavra ou frase:");
        string input = Console.ReadLine();

        // 2. Remover espaços e converter para minúsculo
        string cleanedInput = CleanInput(input);

        // 3. Verificar se a string é um palíndromo
        bool isPalindrome = IsPalindrome(cleanedInput);

        // 4. Exibir se a palavra/frase é ou não um palíndromo
        if (isPalindrome)
        {
            Console.WriteLine($"A frase/palavra \"{input}\" é um palíndromo.");
        }
        else
        {
            Console.WriteLine($"A frase/palavra \"{input}\" não é um palíndromo.");
        }
    

    // Método para limpar a string
    static string CleanInput(string input)
    {
        // Remover caracteres especiais e espaços, e converter para minúsculo
        return Regex.Replace(input.ToLower(), @"[^a-z0-9]", "");
    }

    // Método recursivo que verifica se a string é um palíndromo
    static bool IsPalindrome(string str)
    {
        // 5. Caso base: se string tem 0 ou 1 caractere, retornar true
        if (str.Length <= 1)
        {
            return true;
        }

        // 6. Caso base: se primeiro e último caracteres são diferentes, retornar false
        if (str[0] != str[str.Length - 1])
        {
            return false;
        }

        // 7. Caso recursivo: verificar substring sem primeiro e último caracteres
        return IsPalindrome(str.Substring(1, str.Length - 2));
    }


       
      // Saída esperada:
      /**📝 Exercício 4: Verificador de Palíndromo (Recursivo)
      Digite uma palavra ou frase: radar
      "radar" É um palíndromo!
     
      Digite uma palavra ou frase: programa
      "programa" NÃO é um palíndromo!
     
      Digite uma palavra ou frase: Socorram me subi no onibus em marrocos
      "socorram me subi no onibus em marrocos" É um palíndromo!
      */

    }
    }