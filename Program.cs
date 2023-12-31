namespace JCD1._3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o número de linhas desejado: ");

            int spaces = Convert.ToInt32(Console.ReadLine());
            int asterix = 2;

            for (int i = 0; i < spaces; i++)
            {
                // Espaços em branco à esquerda para alinhar a árvore
                for (int j = 0; j <= (spaces - i); j++)
                {
                    Console.Write(" ");
                }
                // Laço para iterar sobre cada linha da árvore
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("**");
                }
                Console.WriteLine();

            }
        }
    }
}