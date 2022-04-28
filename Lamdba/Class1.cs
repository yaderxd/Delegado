using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persona;

namespace Lamdba
{
    public class Class1
    {
        static void main(string[] args)
        {
            Action<string> saludo = cadena =>
            {
                Console.WriteLine($"Un Saludo a la Grasa{cadena}");
            };
            saludo("Juan");
            Action<string, string> saludo2 = (cadena1, cadena2) =>
             {
                 Console.WriteLine($"XD{cadena1},{cadena2}");
             };
            saludo2("Said","Mondongo");

            List<int> listanumero = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            listanumero.ForEach(numerito =>
            {
                if (numerito % 2==0)
                {
                    Console.WriteLine(numerito);
                }
            });
            List<Persona5> listado = new List<Persona5> 
            {
                new Persona5() { Nombre = "Bryan", Apellido = "Alexander", Edad = 19 },
                new Persona5() { Nombre = "Dennis", Apellido = "solis", Edad = 19 },
                new Persona5() { Nombre = "Hernaldo", Apellido = "Gomez", Edad = 19 },
            };
            foreach (var item in listado.Where(Object=>Object.Edad>18))
            {

            }
        Console.ReadLine();
        }
    }
}
