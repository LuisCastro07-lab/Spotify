using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
// Libreria de audio
using WMPLib;


namespace Spotify
{
    class Cancion
    {
        private String[] canciones;
        private String[] playlist;
        private String song;
        private int contador;
        protected int number_song;

        WindowsMediaPlayer sonido = new WindowsMediaPlayer();
        public Cancion()
        {
            contador = 0;
            canciones = new String[14];
            playlist = new String[14];
            canciones[0] = "EVIL, INTERPOL";
            canciones[1] = "THE DARK OF THE MATINEE, FRANZ FERDINAND";
            canciones[2] = "STOCKOLM SYNDROME, MUSE";
            canciones[3] = "THE BAY, METRONOMY";
            canciones[4] = "MANUELA, FARINA";
            canciones[5] = "CLAP CLAP, DELAPORTE";
            canciones[6] = "CHOP SUEY, SYSTEM OF A DOWN";
            canciones[7] = "SWEET DREAMS, EURYTHMICS";
            canciones[8] = "HOTEL CALIFORNIA, EAGLES";
            canciones[9] = "REPTILIA, THE STROKES";
            canciones[10] = "UNFORGETTABLE, FRENCH MONTANA";
            canciones[11] = "PUMPED UP KICKS, FOSTER THE PEOPLE";
            canciones[12] = "SOMEBODY ELSE, THE 1975";
        }
        public void buscar_canciones()
        {
            Random rnd = new Random();
            int num = rnd.Next(12);
            String can;
            Console.WriteLine("Ingrese el nombre de la cancion (recuerda escribir la cancion como aparece en la lista)");
            can = Console.ReadLine();
            for (int i = 0; i <= 14; i++)
            {
                if (can == canciones[i])
                {
                    Console.WriteLine("La cancion que ha elegido es " + canciones[i]);
                    song = can;
                    number_song = i;
                    break;
                }
                if (i >= 13)
                {
                    Console.WriteLine("No se ha encontrado la cancion\n");
                    Console.WriteLine("Se va a escoger una cancion aleatoriamente");
                    song = canciones[num];
                    Console.WriteLine(song);
                    break;
                }
            }
        }
        public void mostrar_canciones()
        {
            int i = 0;
            do
            {
                Console.WriteLine(canciones[i]);
                i++;
            } while (i <= 13);
        }
        public void mostrar_playlist()
        {
            int i = 0;
            do
            {
                Console.WriteLine(playlist[i]);
                i++;
            } while (i <= 13);
        }
        public void reproducir_cancion()
        {
            
            // sentencia de reproduccion de audio 
            //SoundPlayer splayer = new SoundPlayer(@"EVIL.wav");
            //splayer.Play();
            try
            {
                sonido.controls.stop();
                sonido.URL = ubicacion(number_song);
                sonido.controls.play();
                Console.WriteLine("Reproduciendo");
                Thread.Sleep(2000);
            }
            catch(Exception)
            {
                Console.WriteLine("Error al reproducir");
            }
            
            
        }
        public void agregar_cancion_playlist()
        {
            for (int i = 0; i<=13; i++)
            {
                if(song == playlist[i])
                {
                    Console.WriteLine("La cancion ya esta agregada a la playlist");
                    break;
                }
                else
                {
                    playlist[contador] = song;
                    Console.WriteLine("Cancion agregada a playlist: " + playlist[contador]);
                    contador++;
                    break;
                }
            }
        }

        public string ubicacion(int a)
        {
            a++;
            string DirecionUrl = "";
            switch (a)
            {
                case 1:
                    DirecionUrl = "C:\\Users\\luisc\\Desktop\\Spotify\\EVIL.mp3";
                    break;
                case 2:
                    DirecionUrl = "C:\\Users\\luisc\\Desktop\\Spotify\\THE_DARK_SIDE_OF_THE_MATINEE.mp3";
                    break;
                case 3:
                    DirecionUrl = "C:\\Users\\luisc\\Desktop\\Spotify\\STOCKOLM_SYNDROME.mp3";
                    break;
                case 4:
                    DirecionUrl = "C:\\Users\\luisc\\Desktop\\Spotify\\THE_BAY.mp3";
                    break;
                case 5:
                    DirecionUrl = "C:\\Users\\luisc\\Desktop\\Spotify\\REPTILIA.mp3";
                    break;
                case 6:
                    DirecionUrl = "C:\\Users\\luisc\\Desktop\\Spotify\\REPTILIA.mp3";
                    break;
                case 7:
                    DirecionUrl = "C:\\Users\\luisc\\Desktop\\Spotify\\CHOP_SUEY.mp3";
                    break;
                case 8:
                    DirecionUrl = "C:\\Users\\luisc\\Desktop\\Spotify\\REPTILIA.mp3";
                    break;
                case 9:
                    DirecionUrl = "C:\\Users\\luisc\\Desktop\\Spotify\\HOTEL_CALIFORNIA.mp3";
                    break;
                case 10:
                    DirecionUrl = "C:\\Users\\luisc\\Desktop\\Spotify\\REPTILIA.mp3";
                    break;
                case 11:
                    DirecionUrl = "C:\\Users\\luisc\\Desktop\\Spotify\\UNFORGETTABLE.mp3";
                    break;
                case 12:
                    DirecionUrl = "C:\\Users\\luisc\\Desktop\\Spotify\\PUMPED_UP_KICKS.mp3";
                    break;
                case 13:
                    DirecionUrl = "C:\\Users\\luisc\\Desktop\\Spotify\\SOMEBODY_ELSE.mp3";
                    break;

            }
            return DirecionUrl;
        }
    }
}
