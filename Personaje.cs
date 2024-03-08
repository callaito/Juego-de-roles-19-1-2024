using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_de_roles
{
    public class personaje
    {

        public string nombre { get; set; }
        public string nivel { get; set; }

       

        public virtual string atacar()
        {
            return "";

        }

        public virtual string defenderse()
        {
            return "";

        }

        public virtual string brincar()
        {
            return "";

        }


    }
}


