using Project.Enumeradores;
using Project.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Modelos
{
    // Clase Perro
    public class Perro : Mascota, IAcariciable
    {
        public Perro(string nombre, int edad, Temperamento temperamento)
            : base(nombre, edad, temperamento)
        {
        }

        public void MoverCola()
        {
            Console.WriteLine("Mueve la cola");
        }

        public void Gruñir()
        {
            Console.WriteLine("Grr real hasta la muerte");
        }

        public void ResponderACaricia()
        {
            Console.WriteLine("Mueve la cola");
        }
    }
 }
