using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Interfaces;

namespace Project.Modelos
{
    public class Persona
    {
        private static int contadorId = 1;

        public int Id { get; }

        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("El nombre de la persona no debe estar en blanco.");
                    return;
                }

                _nombre = value;
            }
        }

        public List<Mascota> Mascotas { get; }

        public Persona(string nombre)
        {
            Id = contadorId++;
            Nombre = nombre;
            Mascotas = new List<Mascota>();
        }

        public List<Mascota> ObtenerMascotas()
        {
            return Mascotas;
        }

        public Mascota ObtenerMascotaPorId(string id)
        {
            foreach (var mascota in Mascotas)
            {
                if (mascota.Id == id)
                {
                    return mascota;
                }
            }
            return null;
        }

        public void AgregarMascota(Mascota mascota)
        {
            Console.WriteLine($"{this.Nombre} agrega a {mascota.Nombre} a sus mascotas");
            Mascotas.Add(mascota);
        }

        public void AcariciarMascotas()
        {
            foreach (var mascota in Mascotas)
            {
                if (mascota is IAcariciable acariciable)
                {
                    acariciable.ResponderACaricia();
                }
            }
        }

    }
}
