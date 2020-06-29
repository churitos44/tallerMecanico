using System;
using System.Collections.Generic;
using System.Text;

namespace Taller
{
    class Carro
    {
        private int Id { get; set; }
        public string Marca { get; set; }
        public int Modelo { get; set; }
        public string Color { get; set; }
        public int Matricula { get; set; }

        public string Describir()
        {
            return $"numero de  matricula del carro: {Matricula} marca del carro: {Marca} modelo :{Modelo} y por ultimo colordel carro :{Color}";
        }


    }




}
