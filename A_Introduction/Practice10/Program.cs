namespace Practice10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entrada = int.Parse(Console.ReadLine());
            for (int i = 0; i <= entrada; i++)
            {
                if ((i & 1) == 1) Console.WriteLine(i);
            }
        }
    }
}