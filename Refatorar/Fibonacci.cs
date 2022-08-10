using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;

namespace Refatorar
{
    public class Fibonacci
    {

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine(new String('-', 50));
            Console.WriteLine($"              SEQUENCIA FIBONACCI  ");
            Console.WriteLine(new String('-', 50));
            Console.WriteLine("*         Imprima uma Seuquencia Fibonacci       *");
            Console.WriteLine("*                                                *");
            Console.WriteLine("*              Digite um numero                  *");
            Console.WriteLine("*                                                *");            
            Console.WriteLine(new String('-', 50));
            
            

            int numeroFibonacci = int.Parse(Console.ReadLine());///1000



            // metodo SomarFibonacci em uma lista 
            List<int> lstSeqFibonacci = SomarFibonacci(numeroFibonacci);
            //Chama o metodo ExibirFibonacci " Imprimir a lista "
            ExibirFibonacci(lstSeqFibonacci, numeroFibonacci);
            //Chama o metodo GravarFibonacci " Gravar a lista em txt "
            GravarFibonacci(lstSeqFibonacci, numeroFibonacci);





        }
        public static List<int> SomarFibonacci(int numero) 
        {
            List<int> fibonacci = new List<int>();

            try
            { 

                Console.Clear();

                int soma = 0;
                int fib = 1;

                fibonacci.Add(soma);
                fibonacci.Add(fib);

                while (soma < numero)
                {
                    soma += fib;
                    fib += soma;
                    if (soma <= numero)
                    {
                        fibonacci.Add(soma);
                    }
                    if (fib <= numero)
                    {
                        fibonacci.Add(fib);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(new String('-', 50));
                Console.WriteLine("       Caracteres invalidos ");
                Console.WriteLine("Sistema Aceita apenas Caracteres Numericos ");
                Console.WriteLine("       Aperte Enter e tente novamente ");
                Console.WriteLine(new String('-', 50));
                Console.WriteLine(ex.Message);
            }

            
          
          
            
            return fibonacci;
            
        }



        public static void ExibirFibonacci(List<int> listanumero, int numero)

        {
            int contar = listanumero.Count;
            Console.WriteLine(new String('-', 60));
            Console.WriteLine($"           SEQUENCIA FIBONACCI  ");
            Console.WriteLine("");
            Console.WriteLine($"       Entre O a {numero} temos {contar} numeros ");
            Console.WriteLine(new String('-', 60));
            foreach (var item in listanumero)
            {

                Console.WriteLine(item);


            }
            

        }

      

        public static void GravarFibonacci(List<int> listanumero, int numero)
        {

            string folderPath = @"C:\Test";
            if (Directory.Exists(folderPath)== false)
            {
                Directory.CreateDirectory(folderPath);

            }
          
            string txt = @$"C:\Test\Fibonacci.txt";

            StreamWriter sw;
            if (File.Exists(txt) == true)
            {

                sw = File.AppendText(txt);
            }
            else
            {
                sw = File.CreateText(txt);
                sw.WriteLine(new String('-', 60));
                sw.WriteLine($"*       Tabela de  Fibonacci *");
                sw.WriteLine(new String('-', 60));

            }

            int contar = listanumero.Count;
            sw.WriteLine(new String('-', 60));
            sw.WriteLine($"           SEQUENCIA FIBONACCI  ");
            sw.WriteLine("");
            sw.WriteLine($"       Entre O a {numero} temos {contar} numeros ");
            sw.WriteLine(new String('-', 60));
            foreach (var item in listanumero)
            {

                sw.WriteLine($"{item}");


            }
            sw.Close();

        }
    }
}

