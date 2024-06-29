using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string origin = "AAAAA BBB ccc CR7 bababa    ";

            // Imprimindo a string original
            Console.WriteLine($"Original: \"{origin}\"");

            // Comprimento da string
            Console.WriteLine($"Length: {origin.Length}");

            // Converte para maiúsculas
            Console.WriteLine($"ToUpper: \"{origin.ToUpper()}\"");

            // Converte para minúsculas
            Console.WriteLine($"ToLower: \"{origin.ToLower()}\"");

            // Remove espaços em branco do início e do fim
            Console.WriteLine($"Trim: \"{origin.Trim()}\"");

            // Remove todos os espaços em branco
            Console.WriteLine($"Replace (spaces with empty string): \"{origin.Replace(" ", "")}\"");

            // Substitui um caractere por outro
            Console.WriteLine($"Replace (A with Z): \"{origin.Replace('A', 'Z')}\"");

            // Substitui uma substring por outra
            Console.WriteLine($"Replace (\"BBB\" with \"XYZ\"): \"{origin.Replace("BBB", "XYZ")}\"");

            // Divide a string em um array de substrings
            string[] words = origin.Split(' ');
            Console.WriteLine("Split by spaces:");
            foreach (string word in words)
            {
                Console.WriteLine($"- \"{word}\"");
            }

            // Verifica se a string contém uma substring específica
            Console.WriteLine($"Contains \"CR7\": {origin.Contains("CR7")}");

            // IndexOf: Retorna a posição da primeira ocorrência de um caractere ou substring
            Console.WriteLine($"IndexOf \"BBB\": {origin.IndexOf("BBB")}");

            // LastIndexOf: Retorna a posição da última ocorrência de um caractere ou substring
            Console.WriteLine($"LastIndexOf \"a\": {origin.LastIndexOf("a")}");

            // Substring: Extrai uma substring da string
            Console.WriteLine($"Substring (start at 6, length 3): \"{origin.Substring(6, 3)}\"");

            // StartsWith: Verifica se a string começa com uma substring específica
            Console.WriteLine($"StartsWith \"AAAAA\": {origin.StartsWith("AAAAA")}");

            // EndsWith: Verifica se a string termina com uma substring específica
            Console.WriteLine($"EndsWith \"bababa    \": {origin.EndsWith("bababa    ")}");

            // Insert: Insere uma substring em uma posição específica
            Console.WriteLine($"Insert (\"HELLO\" at index 5): \"{origin.Insert(5, "HELLO")}\"");

            // Remove: Remove parte da string a partir de uma posição específica
            Console.WriteLine($"Remove (start at index 5): \"{origin.Remove(5)}\"");

            // ToCharArray: Converte a string em um array de caracteres
            char[] chars = origin.ToCharArray();
            Console.WriteLine("ToCharArray:");
            foreach (char c in chars)
            {
                Console.Write($"'{c}', ");
            }
            Console.WriteLine();

            // Join: Concatena um array de strings usando um separador
            string joined = string.Join("-", words);
            Console.WriteLine($"Join (with '-'): \"{joined}\"");

            // Format: Formata a string
            string formatted = string.Format("This is a formatted string: {0}", origin);
            Console.WriteLine($"Format: \"{formatted}\"");

            // PadLeft: Preenche a string à esquerda com espaços ou um caractere específico
            Console.WriteLine($"PadLeft (30, '*'): \"{origin.PadLeft(30, '*')}\"");

            // PadRight: Preenche a string à direita com espaços ou um caractere específico
            Console.WriteLine($"PadRight (30, '*'): \"{origin.PadRight(30, '*')}\"");
        }
    }
}
