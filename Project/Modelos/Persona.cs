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
        public string Nombre { get; }
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
            return Mascotas.Find(m => m.Id == id);
        }

        public void AgregarMascota(Mascota mascota)
        {
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
