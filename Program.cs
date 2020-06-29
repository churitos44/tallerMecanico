using System;
using System.Diagnostics.CodeAnalysis;

namespace Taller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDOS AL TALLER GALAXIA");
            Console.ReadKey();


            ///instancias

            Mecanico mecanico = new Mecanico
            {
                Id = 1,
                Nombre = "David ",
                Apellido = "Oña",
                Direccion = "Amaguaña",
                Experiencia = 5,
                ManoDeObra = 100

            };
            Cliente cliente = new Cliente
            {
                Nombre = "Daniela",
                Apellido = "Sanchez",
                Direccion = "Pintag",
                Edad = 20
            };

            Carro carro = new Carro
            {
                Marca = "Toyota",
                Modelo = 2015,
                Color = "rojo",
                Matricula = 450001
            };

            Repuesto repuesto = new Repuesto
            {
                Nombre = "frenos",
                Marca = "vinatur",
                cantidad = 1,
                Precio = 50
            };
        
            string saludo = mecanico.SaludarM();
            Console.WriteLine(saludo);

            Console.WriteLine("taller Galaxi  a su disposocion");
            Console.ReadKey();

            string saludo2 = cliente.Saludar();
            Console.WriteLine(saludo2);

            string diagnostico= cliente.dañoDelCarro();
            Console.WriteLine(diagnostico);

            string reparo = mecanico.Reparar();
            Console.WriteLine(reparo);
            Console.WriteLine("Nesecito los datos del carro por favor :");

            string datosCarro = carro.Describir();
            Console.WriteLine(datosCarro);

            Console.ReadKey();

            String repuestoCarro = repuesto.informacionRepuesto();
            Console.WriteLine("repuesto que necesita :");
            Console.WriteLine( repuestoCarro);

            string respuesta;
            Console.Write("desea comprar el  repueto ?:");
            respuesta = (Console.ReadLine());

            string empresaRepuesto = repuesto.MisRepuestops(); ;
            Console.WriteLine(empresaRepuesto);
            
            string compra = repuesto.comprar();
            Console.WriteLine(compra);
            Console.WriteLine("sucompra se realizo con exito");

            Console.ReadKey();

            string tenerRepuesto = mecanico.obtener();
            Console.WriteLine(tenerRepuesto);

            string prueba = cliente.Probar();
            Console.Write(prueba);
            Console.WriteLine("");
            string pago = mecanico.costo();
            Console.WriteLine(pago);
            Console.ReadKey();
            int suma;
            suma = repuesto.Precio + mecanico.ManoDeObra;
            Console.WriteLine(suma);











        }

    }
}

