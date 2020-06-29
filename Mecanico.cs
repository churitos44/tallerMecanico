using System;
using System.Collections.Generic;
using System.Text;

namespace Taller
{
    class Mecanico
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int Experiencia { get; set; }

        public int ManoDeObra { get; set; }


        public string SaludarM()
        {
            return $"Hola mi nombre es {Nombre} soy mecanico he trabajo en mecanica de autos  durante {Experiencia} de años ";
        }

        public string Reparar()
        {
            return $"Lo revisare en esta semana y le comunico  para que retire el auto no se preocupe queda en buenas manos ";
        }

        public string obtener()
        {
            return $" ya con el repuesto su carro esta arreglado retirarlo  el lunes por favor";
        }
        public string costo()
        {
            return $" su cuenta es de : ";
        }


    }
}
