using System;
using System.Collections.Generic;
using System.Text;

namespace Taller
{
    class Cliente
    {
        private int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public  int Edad { get; set; }

        public string Saludar()
        {
            return $"Hola soy  {Nombre}  necesito ayuda con mi auto ";
        }

        public string dañoDelCarro()
        {
            return $" Bueno   mi auto   tine problemas con los frenos  tuve un accidente que casi choco ";
        }
        public string Probar()
        {
            return $"mi carro quedo muy bien  gracias por su ayuda  ¡";
        }

        public string Cancelar()
        {
            return $" ";
        }

    }
}
