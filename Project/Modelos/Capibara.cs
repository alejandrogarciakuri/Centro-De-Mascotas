using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Modelos
{
    public class Capibara : Mascota
    {
        public Capibara(string nombre, int edad)
            : base(nombre, edad, Temperamento.AMABLE)
        {
        }

        public override void HacerRuido()
        {
            Console.WriteLine("cui cui");
        }
    }

}
