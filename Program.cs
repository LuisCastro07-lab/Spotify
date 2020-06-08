using System;
using System.Threading;

namespace Spotify
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc, o;
            Cancion spotify = new Cancion();
            Console.WriteLine("Bienvenido a Spotify\n");
            do
            {
                
                Console.WriteLine("\nMenu de opciones\n1)Buscar cancion por nombre\n2)Mostrar lista de canciones disponible\n3)Mostrar playlist\n4)Salir\n");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        spotify.buscar_canciones();
                        Console.WriteLine("\n1)Reproducir cancion\n2)Agregar a playlist\n3)Regresar\n");
                        o = int.Parse(Console.ReadLine());
                        if (o == 1)
                        {
                            spotify.reproducir_cancion();
                        }
                        if (o == 2)
                        {
                            spotify.agregar_cancion_playlist();
                        }
                        else
                        {
                            Console.WriteLine("Regresando...");
                            Thread.Sleep(2000);
                        }
                        break;
                    case 2:
                        spotify.mostrar_canciones();
                        break;
                    case 3:
                        spotify.mostrar_playlist();
                        break;
                    case 4:
                        Console.WriteLine("Gracias por utlizar nuestra plataforma");
                        break;
                }
                
            } while (opc != 4);
        }
    }
}