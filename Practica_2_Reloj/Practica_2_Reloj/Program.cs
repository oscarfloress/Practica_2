using System;
using System.Threading;

namespace Practica_2_Reloj
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            DateTime fechaHoy;
            Console.WriteLine(" 1. Cronometro\n 2. Reloj");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1: for (int hora = 0; hora < 24; hora++)
                        {
                            for (int minuto = 0; minuto < 60; minuto++)
                            {
                                for (int segundo = 0; segundo < 60; segundo++)
                                {
                                    Console.Clear();
                                    if (hora < 10)
                                        Console.Write("0" + hora + ":");
                                    else Console.Write(hora + ":");
                                    if (minuto < 10)
                                        Console.Write("0" + minuto + ":");
                                    else Console.Write(minuto + ":");
                                    if (segundo < 10)
                                        Console.Write("0" + segundo);
                                    else Console.Write(segundo);
                                    Thread.Sleep(1000);
                                }
                            }
                        }
                    break;
                case 2: while (true)
                    {
                        Console.Clear();
                        fechaHoy = DateTime.Now;
                        if (fechaHoy.Hour < 10)
                            Console.Write("0" + fechaHoy.Hour + ":");
                        else Console.Write(fechaHoy.Hour + ":");
                        if (fechaHoy.Minute < 10)
                            Console.Write("0" + fechaHoy.Minute + ":");
                        else Console.Write(fechaHoy.Minute + ":");
                        if (fechaHoy.Second < 10)
                            Console.Write("0" + fechaHoy.Second);
                        else Console.Write(fechaHoy.Second);
                        Thread.Sleep(1000);
                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}
