using System;

namespace piedra__papel_o_tijera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int jugada_del_ordenador, jugada_del_usuario;
            Random rand = new Random();
            Console.WriteLine("Selecciona el valor de jugada del usuario.");
            Console.WriteLine("\t1.- Piedra");
            Console.WriteLine("\t2.- Papel");
            Console.WriteLine("\t3.- Tijera");
            Console.Write("\t: ");
            do
            {
                jugada_del_usuario = int.Parse(Console.ReadLine());
                if (jugada_del_usuario < 1 || jugada_del_usuario > 3)
                    Console.Write("Valor incorrecto. Ingr\u00E9salo nuevamente.: ");
            } while (jugada_del_usuario < 1 || jugada_del_usuario > 3);
            jugada_del_ordenador = 1 + rand.Next(3);
            if (jugada_del_ordenador == 1)
                Console.WriteLine("La jugada del ordenador es Piedra");
            if (jugada_del_ordenador == 2)
                Console.WriteLine("La jugada del ordenador es Papel");
            if (jugada_del_ordenador == 3)
                Console.WriteLine("La jugada del ordenador es Tijera");
            if (jugada_del_usuario == jugada_del_ordenador)
                Console.WriteLine("Empate");
            if ((jugada_del_usuario == 1 && jugada_del_ordenador == 3) || (jugada_del_usuario == 2 && jugada_del_ordenador == 1) || (jugada_del_usuario == 3 && jugada_del_ordenador == 2))
                Console.WriteLine("Gana usuario");
            if ((jugada_del_usuario == 3 && jugada_del_ordenador == 1) || (jugada_del_usuario == 1 && jugada_del_ordenador == 2) || (jugada_del_usuario == 2 && jugada_del_ordenador == 3))
                Console.WriteLine("Gana ordenador");
            Console.WriteLine("Valor de jugada del ordenador: " + jugada_del_ordenador);
            Console.WriteLine();
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();
        }
    }

}
    

