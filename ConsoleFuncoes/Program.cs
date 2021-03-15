using System;

namespace ConsoleFuncoes
{
    // funções "internal" será usada somente dentro desse namespace

    class Program2
    {
        static void Main(String[] args)
        {
            //Program.Calcular() //não é possível chamar essa função pois ela não é publica

            //só consigo chamar o calcular2 depois de criar um novo objeto, isso porque a função não é estatica
            var pg = new Program();
            pg.Calcular2();
        }
    }
    class Program
    {
        //funções "protected" funcionam somente dentro desse programa
        static int Calcular()
        {
            int a = 1;
            int b = 2;
            int c = a + b;
            return c;
        }

        public int Calcular2()
        {
            int a = 1;
            int b = 2;
            int c = a + b;
            return c;
        }

        public static void MostrarMensagemNaTela()
        {
            Console.WriteLine("Olá");
        }

        public static void Tabuada(int numero)
        {
            Console.WriteLine("=======================================");
            for (int i = 1; i<=10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " +  (numero * i));    
            }
        }
        static void Main(string[] args)
        {
            int calculo = Calcular();
            Console.WriteLine(calculo);
            MostrarMensagemNaTela();
            Tabuada(9);
            Tabuada(5);

            Console.Read();
        }
    }
}
