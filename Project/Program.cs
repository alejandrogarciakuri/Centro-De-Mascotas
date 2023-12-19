using System;
using System.Collections.Generic;
using System.Linq;
using Project.Modelos;
using Project.Interfaces;
using Project.Enumeradores;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            MostrarMenuPrincipal();
            string opcionSeleccionada = Console.ReadLine();

            if (opcionSeleccionada == "1")
            {
                ManejarOpcionAdministracionDelCentro();
            }
            else if (opcionSeleccionada == "2")
            {
                ManejarOpcionAdministracionDeAdopciones();
            }
            else if (opcionSeleccionada == "3")
            {
                ManejarOpcionAdministracionDeBienestarAnimal();
            }
            else if (opcionSeleccionada == "4")
            {
                ManejarOpcionSimulaciónDeInteracciones();
            }
            else
            {
                Console.WriteLine("Fin del programa.");
                Console.ReadKey();
                return;
            }
        }
    }

    static void MostrarMenuPrincipal()
    {
        Console.WriteLine("Menú principal:");
        Console.WriteLine("1) Administracion del centro");
        Console.WriteLine("2) Administracion de adopciones");
        Console.WriteLine("3) Administración de bienestar animal");
        Console.WriteLine("4) Simulación de interacciones");
        Console.WriteLine("5) Finalizar programa");
    }

    static void MostrarMenuAdministracionDelCentro()
    {
        Console.WriteLine("Menú Administracion del centro:");
        Console.WriteLine("1) Administracion de personas");
        Console.WriteLine("2) Administracion de mascotas");
        Console.WriteLine("3) Regresar a menú anterior");
    }

    static void MostrarMenuAdministracionDeAdopciones()
    {
        Console.WriteLine("Menú Administracion de adopciones:");
        Console.WriteLine("1) Ver mascotas disponibles para adoptar");
        Console.WriteLine("2) Adoptar mascota");
        Console.WriteLine("3) Regresar a menú anterior");
    }

    static void MostrarMenuAdministracionDeBienestarAnimal()
    {
        Console.WriteLine("Menú Administracion de bienestar animal:");
        Console.WriteLine("1) Servicio de Spa");
        Console.WriteLine("2) Corte de pelo");
        Console.WriteLine("3) Volver al menu anterior");
    }

    static void ManejarOpcionAdministracionDelCentro()
    {

    }

    static void ManejarOpcionAdministracionDeAdopciones()
    {

    }

    static void ManejarOpcionAdministracionDeBienestarAnimal()
    {

    }

    static void ManejarOpcionSimulaciónDeInteracciones()
    {

    }
}