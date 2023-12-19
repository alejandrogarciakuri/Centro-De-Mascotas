using System;
using Project.Enumeradores;
using Project.Interfaces;

namespace Project.Modelos
{
    public class Gato : Mascota, IAcariciable
    {
        private int _edad;
        public int Edad
        {
            get { return _edad; }
            set
            {
                if (Edad > 18)
                {
                    throw new Exception("La edad maxima de un gato es de 18 años.");
                    return;
                }

                _edad = value;
            }
        }

        public Gato(string nombre, int edad, Temperamento temperamento) : base(nombre, edad, temperamento)
        {
            Edad = edad;
        }

        public void HacerRuido()
        {
            Console.WriteLine("miau miau");
        }

        public void Ronronear()
        {
            Console.WriteLine("Ronronea");
        }

        public void Rasguñar()
        {
            Console.WriteLine("Rasguña");
        }

        public void ResponderACaricia()
        {
            if (Temperamento == Temperamento.Amable || Temperamento == Temperamento.Nervioso)
            {
                Ronronear();
            }
            else if (Temperamento == Temperamento.Agresivo)
            {
                Rasguñar();
            }
        }
    }
}

