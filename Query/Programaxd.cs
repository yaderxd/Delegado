using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persona;

namespace Query
{
    class Programaxd
    {
        static void main(string[] args)
        {
            List<Persona5> listadopersona = new List<Persona5>
            {
            new Persona5() { Nombre = "Juan", Apellido = "Gomez", Edad = 18},
            new Persona5() { Nombre = "Leandro", Apellido = "Marcelo", Edad = 18},
            new Persona5() { Nombre = "Bryan", Apellido = "Alexander", Edad = 18},
            new Persona5() { Nombre = "Cesar", Apellido = "Vivas", Edad = 18},
            new Persona5() { Nombre = "Oscar", Apellido = "Garcia", Edad = 18}
            };
            var listadoconfiltro=from item in listadopersona where item.Edad>18 select item;
            foreach (var item in listadoconfiltro)
            {
                Console.WriteLine($"{item.Nombre},{item.Apellido}");
            }
            Console.ReadLine();
        }
    }
}
