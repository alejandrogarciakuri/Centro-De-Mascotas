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
        private int _edad;
        public int Edad
        {
            get { return _edad; }
            set
            {
                if (Edad > 14)
                {
                    throw new Exception("La edad maxima de un perro solo es de 14 años.");
                    return;
                }

                _edad = value;
            }
        }

        public Perro(string nombre, int edad, Temperamento temperamento) : base(nombre, edad, temperamento)
        {
        }

          public override void HacerRuido()
    {
        Console.WriteLine("guau guau");
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
