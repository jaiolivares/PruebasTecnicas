using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        public struct ATM
        {
            public int Id { get; set; }
            public (int, int) Location { get; set; }
        }

        private static void Main(string[] args)
        {
            var listOfATMs = new List<ATM>()
            {
                new ATM { Id = 1, Location = (0, 0) },
                new ATM { Id = 2, Location = (0, 2) },
                new ATM { Id = 3, Location = (1, 1) },
                new ATM { Id = 4, Location = (1, 3) },
                new ATM { Id = 5, Location = (5, 4) },
                new ATM { Id = 6, Location = (2, 6) },
                new ATM { Id = 7, Location = (3, 1) },
                new ATM { Id = 8, Location = (3, 4) },
                new ATM { Id = 9, Location = (4, 5) },
                new ATM { Id = 10, Location = (7, 3) }
            };

            //Lista que retorna la diferencia entre el punto X e Y
            foreach (var item in listOfATMs)
            {
                var diferenciaEntreDosPuntos = item.Location.Item1 - item.Location.Item2;
                Console.WriteLine(item.Id + ": " + diferenciaEntreDosPuntos);
            }

            //p1: entiendo que es el elemento de la posición 1, o sea el ID=2
            var p1 = listOfATMs.Select(x => x.Id == 2);

            //p2: entiendo que es el elemento de la posición 2, o sea el ID=3
            var p2 = listOfATMs.Select(x => x.Id == 3);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}