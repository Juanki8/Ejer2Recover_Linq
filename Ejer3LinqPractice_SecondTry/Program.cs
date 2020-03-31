using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3LinqPractice_SecondTry
{
    public class Program
    {
        static List<Coche> listaCoches = new List<Coche>();

        public static void Main(string[] args)
        {

        }
        static List<Coche> Ejer1()
        {
            using (StreamReader leer = new StreamReader("Cars.json"))
            {
                string json = leer.ReadToEnd();
                List<Coche> resultado = JsonConvert.DeserializeObject<List<Coche>>(json);
                return resultado;
            }
        }
        static void Ejer2()
        {
            var coches = listaCoches.GroupBy(x => x.Maker).Select(y => y.First());
            foreach (var c in coches)
            {
                Console.WriteLine("Fabricante :" + c.Maker);
            }
        }
        static void Ejer3()
        {
            var coches = listaCoches.GroupBy(x => x.Color).Select(y => y.First());
            foreach (var c in coches)
            {
                Console.WriteLine("Color :" + c.Color + "Fabricante :" + c.Maker);
            }
        }
        static void Ejer4()
        {
            var coches = listaCoches.Where(x => x.Color == "Green");

            foreach (var c in coches)
            {
                Console.WriteLine("Frabricante :" + c.Maker + "Modelo :" + c.Model);
            }
        }

        static void Ejer5(double lat, double longi)
        {
            var coches = listaCoches.Where(x => x.Latitude == lat && x.Longitude == longi);
            foreach (var c in coches)
            {
                if (c.Year == 1992)
                {
                    Console.WriteLine("Correcto");
                }
                else
                {
                    Console.WriteLine("Falso");
                }
            }

        }
        static void Ejer6(List<Coche> listaCoches)
        {
            var coches = listaCoches.Where(x => x.Year >= 2001);
            foreach (var c in coches)
            {
                Console.WriteLine(c.Maker + " - " + c.Model);
            }

        }

        static void Ejer7(List<Coche> listaCoches)
        {

            var coches = listaCoches.Where(x => x.Location.Latitude == null && x.Location.Longitude == null);

            foreach (var c in coches)
            {

                Console.WriteLine("Modelo: " + c.Model + " Fabricante: " + c.Maker);

            }

        }

        static void Ejer8(List<Coche> listaCoches)
        {
            var coches = listaCoches.Where(x => x.Year >= 2000 && x.Color == "Blue");
            foreach (var c in coches)
            {
                Console.WriteLine(c);
            }
        }

        static void Ejer9(List<Coche> listaCoches)
        {
            var coches = listaCoches.GroupBy(x => x.Maker);
            foreach (var c in coches)
            {
                foreach (var co in coches)
                {
                    Console.WriteLine(co.ToString());
                }
            }
        }

        static void Ejer10(List<Coche> listaCoches)
        {
            var coches = listaCoches.GroupBy(x => x.Model).Select(y => y.First());
            foreach (var c in coches)
            {
                Console.WriteLine(c.Maker + " - " + c.Color);
            }

            Console.ReadKey();
        }

        static void Ejer11(List<Coche> listaCoches)
        {
            for (int i = 0; i < listaCoches.Count; i += 10)
            {
                var coches = listaCoches.Skip(0 + i).Take(10).Select(y => y.id);
                
                foreach (var c in coches)
                {
                    Console.WriteLine(c);
                }

            }

        }
        static void Ejer12(List<Coche> listaCoches)
        {
            var coches = listaCoches.Where(x => x.Maker == "Suzuki" && x.Year > 2001).Take(1);
            foreach (var c in coches)
            {
                Console.WriteLine(c);
            }

        }
        static void Ejer13() 
        {
            var coches = listaCoches.Where(x => x.Year != null);
            foreach (var c in coches)
            {
                Console.WriteLine(c);
            }
        }
        static void Ejer14(List<Coche> listaCoches)
        {
            var coches = listaCoches.Where(x => x.Color == "Pink").GroupBy(y => y.Year);
            foreach (var c in coches)
            {
                Console.WriteLine(c);
            }
        }

        static void Ejer15(List<Coche> listaCoches) 
        {
            var coches = listaCoches.Where(x => x.Maker == "BMW" && x.Year == null && string.IsNullOrEmpty(x.Color));
            foreach (var c in coches)
            {
                Console.WriteLine(c);
            }
        }

        static void Ejer16(List<Coche> listaCoches, string colores, int year)
        {
            var coches = listaCoches.Where(x => x.Color != colores && x.Year != year);

            foreach (var c in coches)
            {
                Console.WriteLine(c);
            }
        }

    }
}
