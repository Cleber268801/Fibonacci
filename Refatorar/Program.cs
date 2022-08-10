using System;
using System.IO;
using System.Collections;
using Refatorar;

class Program
{

    public static void Main()

    {
        Console.Clear();
        Console.WriteLine(new String('-', 50));
        Console.WriteLine($"              SEQUENCIA FIBONACCI  ");
        Console.WriteLine(new String('-', 50));
        Console.WriteLine("*         Gerar uma Seuquencia Fibonacci         *");
        Console.WriteLine("*                                                *");
        Console.WriteLine("*               Digite 1  para ENTRAR            *");
        Console.WriteLine("*                      ou                        *");
        Console.WriteLine("*               Digite 0 para SAIR               *");
        Console.WriteLine(new String('-', 50));

        int resp = int.Parse(Console.ReadLine());

        switch (resp)
        {
            case 1: Fibonacci.Menu(); break;
            case 0: Environment.Exit(0); break;

        }



    }

}