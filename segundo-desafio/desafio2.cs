using System;

class Program
{
    static void Main(string[] args)
    {
        string entrada = Console.ReadLine();
        
        string[] partes = entrada.Split(' ');

        int total = partes.Length - 1;

        Console.WriteLine(total + " interacoes");
    }
}