using Juego_de_roles;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_de_roles_19_1_2024
{
    public class Guerrero : personaje
    {



        public string nombre { get; set; }
        public string nivel { get; set; }

        public string arma_cuerpo { get; set; }



    
        public override string atacar()
        {
            return "";
        }
        public override string defenderse()
        {
            return "";
        }


        public override string brincar()
        {
            return "";
        }


    }
}



       