using System;
using Project.Enumeradores;

namespace Project.Modelos
{
    public class Mascota
    {

        private static int contadorId = 1;

        public string Id { get; }

        public string Nombre { get; }

        public int _edad;
        public int Edad
        {
            get { return _edad; }
            set
            {
                if (Edad <= 0)
                {
                    throw new Exception("La edad debe ser mayor a cero.");
                    return;
                }

                _edad = value;
            }
        }

        public Temperamento Temperamento { get; }

        public Persona Dueño { get; set; }

        public Mascota(string nombre, int edad, Temperamento temperamento)
        {
            Id = GenerarId();
            Nombre = nombre;
            Edad = edad;
            Temperamento = temperamento;
            Dueño = null;
        }

        public void HacerRuido()
        {
            //Falta por implementar el ruido dependiendo de la especie.
        }

        public void CambiarDueno(Persona nuevoDueno)
        {
            if (Dueño != null)
            {
                Console.WriteLine($"El {Id} ha cambiado su dueño a {nuevoDueno.Nombre}");
            }
            Dueño = nuevoDueno;
        }

        private string GenerarId()
        {
            return $"{this.GetType().Name}-{contadorId++}";
        }
    }
}