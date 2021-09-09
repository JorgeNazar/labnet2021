using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Taxi> lstTaxis = new List<Taxi>();
            List<Omnibus> lstOmnibus = new List<Omnibus>();

            int opt;
            do
            {
                Console.WriteLine("Bienvenido");
                Console.WriteLine("1) Ingresar Omnibus ");
                Console.WriteLine("2) Ingresar Taxis ");
                Console.WriteLine("3) ver Lista de Omnibus");
                Console.WriteLine("4) Ver lista de Taxis");
                Console.WriteLine("0) Salir");
                opt = int.Parse(Console.ReadLine());
                if(opt == 1)
                {
                    Omnibus omni = new Omnibus();
                    omni.Descripcion = Descripcion();
                    omni.Pasajeros = MenuPasajeros();
                    omni.Avanzar();
                    lstOmnibus.Add(omni);
                }else if(opt == 2)
                {
                    Taxi taxi = new Taxi();
                    taxi.Descripcion = Descripcion();
                    taxi.Avanzar();
                    taxi.Pasajeros = MenuPasajeros();
                }
                else if(opt == 3)
                {
                    foreach (var bus in lstOmnibus)
                    {
                        Console.WriteLine(bus.Descripcion);
                        if (bus.EnMovimiento == true)
                        { Console.WriteLine("El omnibus se encuentra en movimiento"); }                        
                        Console.WriteLine("Cantidad de pasajeros: " + bus.Pasajeros);
                        Console.WriteLine();
                    }
                    if (lstOmnibus.Count == 0)
                    {
                        Console.WriteLine("No hay Omnibus cargados");
                    }
                }
                else if (opt == 4)
                {
                    foreach (var taxi in lstTaxis)
                    {
                        Console.WriteLine(taxi.Descripcion);
                        if (taxi.EnMovimiento == true)
                        { Console.WriteLine("El taxi se encuentra en movimiento"); }
                        Console.WriteLine("Cantidad de pasajeros: " + taxi.Pasajeros);
                        Console.WriteLine();
                    }
                    if (lstTaxis.Count == 0)
                    {
                        Console.WriteLine("No hay Taxis cargados");
                    }
                }
                Console.WriteLine();
            } while (opt != 0);



        }

        public static int MenuPasajeros()
        {
            Console.WriteLine("Ingrese nro de Pasajeros");
            return int.Parse(Console.ReadLine());
        }
        public static string Descripcion()
        {
            Console.WriteLine("Ingrese la descripcion del vehiculo");
            return Console.ReadLine();
        }

        }
    }
