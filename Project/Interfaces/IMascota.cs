using System;
using Project.Enumeradores;

namespace Project.Interfaces
{
	public interface IMascota
	{
        public int Id { get; set; }

        public string Nombre { get; set; }

        public int Edad { get; set; }

        public Temperamento Temperamento { get; set; }

        public string Dueño { get; set; }

        public void HacerRuido();

        public void CambiarDueño();
    }
}

