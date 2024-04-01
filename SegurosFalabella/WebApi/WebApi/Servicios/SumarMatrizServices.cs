using static WebApi.Servicios.SumarMatrizServices;

namespace WebApi.Servicios
{
    public class SumarMatrizServices
    {
        public class listaMatriz
        {
            public int valor1 { get; set; }
            public int valor2 { get; set; }
            public int valor3 { get; set; }
        }

        public static void RecorreMatriz()
        {
            var suma = RecorreMatrizA();
            //var suma = RecorreMatrizB();
        }

        public static int RecorreMatrizA()
        {
            var matriz = Matriz();

            //var cc = matriz.

            return 0;
        }

        public static List<listaMatriz> Matriz()
        {
            var lstMatriz = new List<listaMatriz>();

            lstMatriz.Add(FilasMatriz(2, 5, 7));
            lstMatriz.Add(FilasMatriz(3, 4, 5));
            lstMatriz.Add(FilasMatriz(4, 1, 3));

            return lstMatriz;
        }

        public static listaMatriz FilasMatriz(int valor1, int valor2, int valor3)
        {
            var fila = new listaMatriz();

            fila.valor1 = valor1;
            fila.valor3 = valor2;
            fila.valor3 = valor3;

            return fila;
        }
    }
}