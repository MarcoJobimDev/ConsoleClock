using System;
using System.Threading;

namespace Clock
{
    class Program
    {
        static void Main(string[] agrs)
        {
            Console.WriteLine("Relógio");
            Menu();
        }
        static void Menu()
        {
            bool control = false;
            string option;

            do
            {
                Console.WriteLine("Crônometro: c ,Timer: t, Sair: s ");
                option = Console.ReadLine().ToLower();

                switch (option)
                {
                    case "c":
                        Stopwatch();
                        control = true;
                        break;
                    case "t":
                        Timer();
                        control = true;
                        break;
                    case "s":
                        control = true;
                        Console.WriteLine("Finalizando Aplicação ");
                        break;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente! ");
                        break;
                }

            } while (control != true);
        }
        static void Stopwatch()
        {
            int hours = 0;
            int minutes = 0;
            int seconds;

            Console.WriteLine("Para iniciar o Cronômetro, aperte Enter ");
            Console.ReadLine();

            for (seconds = 0; seconds <= 60; seconds++)
            {
                if (seconds == 60)
                {
                    seconds = 0;
                    minutes++;
                    if (minutes == 60)
                    {
                        minutes = 0;
                        hours++;
                        if (hours == 24) //Por enquanto vou parar aqui, mas da pra continuar com dias, semanas, meses, etc.
                        {
                            return;
                        }
                        PrintTime(hours, minutes, seconds);
                    }
                }
                else
                {
                    PrintTime(hours, minutes, seconds);
                }
            }

        }
        static void Timer()
        {
            int hours;
            int minutes;
            int seconds;

            Console.WriteLine("Timer \n");

            Console.WriteLine("Horas: ");
            hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Minutos: ");
            minutes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Segundos: ");
            seconds = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Para iniciar, aperte enter");
            Console.ReadLine();

            for (; seconds >= 0; seconds--)
            {
                if (seconds == 0 && minutes > 0)
                {
                    seconds = 59;
                    minutes--;
                    if (minutes == 0 && hours > 0)
                    {
                        minutes = 59;
                        hours--;
                        PrintTime(hours, minutes, seconds);
                    }
                }

                else
                {
                    PrintTime(hours, minutes, seconds);
                }
            }

            Console.Beep();
            Console.WriteLine("Tempo Finalizado");

        }
        static void PrintTime(int hours, int minutes, int seconds)
        {
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine(hours + " : " + minutes + " : " + seconds);
        }
    }
}


