using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Enumeradores;
using Project.Interfaces;

namespace Project.Modelos
{
    public class Capibara : Mascota
    {
        public Capibara(string nombre, int edad)
            : base(nombre, edad, Temperamento.Amable)
        {
        }

       // public override void HacerRuido()
       // {
       //     Console.WriteLine("cui cui");
       // }
    }

}
