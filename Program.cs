using System;
using System.Collections.Generic;
using System.Globalization;

namespace AulaGenerics
{
    internal class Program
    {
        /*
            Generics permitem que classes, interfaces e métodos possam ser
            parametrizados por tipo. Seus benefícios são:
            • Reuso
            • Type safety
            • Performance
            
            Uso comum: coleções         
         */

        static void Main(string[] args)
        {
            /*Exemplo clássico de Generics.*/
            List<string> list = new List<string>();
            list.Add("Maria");
            string name = list[0];

            /* 
                Problema motivador 1 (reuso)

                Deseja-se fazer um programa que leia um conjunto de N números inteiros (N de
                1 a 10), e depois imprima esses números de forma organizada conforme
                exemplo. Em seguida, informar qual foi o primeiro valor informado.


                How many values? 3
                10
                8
                23
                [10, 8, 23]
                First: 10
            */
            PrintService printService = new PrintService();
            
            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }
            printService.Print();
            Console.WriteLine();
            Console.WriteLine("First: " + printService.First());
        }
    }
}
