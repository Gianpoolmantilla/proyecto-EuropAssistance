using System;
using System.Linq;

namespace DesafioTecnico
{
    public class Desafio
    {
        public Desafio()
        {
        }



        public  bool ValidoNombre(string Nombre)
        {
            bool result = ValidName(Nombre);
            if (result)
            {
                Console.WriteLine("validacion correcta");
            }
            Console.WriteLine("===================");

            return result;
        }

        public  string Simplificar(string Fraccion)
        {
            string Result = string.Empty;

            int Numerador = int.Parse(Fraccion.Substring(0, Fraccion.IndexOf("/")));
            int Denominador = int.Parse(Fraccion.Substring(Fraccion.IndexOf("/") + 1));

            int Divisible;
            for (; ; )
            {
                Divisible = 0;
                for (int i = 2; i <= 9; i++)
                {
                    if (Numerador % i == 0 && Denominador % i == 0)
                    {
                        Divisible = i;
                        break;
                    }
                }
                if (Divisible == 0)
                {
                    break;
                }
                Numerador = +Numerador / Divisible;
                Denominador = +Denominador / Divisible;
            }

            return Numerador + "/" + Denominador;
           
        }

        public static bool ValidName(string Nombre)
        {
            bool Result = true;
            if (ValidoMayusculas(Nombre)) // a
            {
                Console.WriteLine("las palabras o iniciales deben empezar con mayusculas");
                Result = false;
            }
            if (ValidarPuntoEnIniciales(Nombre)) //b
            {
                Console.WriteLine("las iniciales deben contener un punto");
                Result = false;
            }
            if (ValidoNombresYapellidos(Nombre)) //c
            {
                Console.WriteLine("solo nombres o apellidos no son validos");
                Result = false;
            }
            if (ValidoNombres(Nombre)) //d
            {
                Console.WriteLine("inicial como primer nombre y palabra como segundo no es valido");
                Result = false;
            }

            if (ValidoApellidoCompleto(Nombre)) //e
            {
                Console.WriteLine("el apellido no puede ser inicial");
                Result = false;
            }

            if (ValidoPalabrasQueNoFinalicenConPunto(Nombre))
            {
                Console.WriteLine("las palabras no deben tener punto");
                Result = false;
            }

            return Result;

        }

        private static bool ValidoNombres(string Nombre)
        {
            var Valido = Nombre.Split(" ").Count();
            bool Result = false;
            if (Valido == 3)
            {
                //verifico
                var palabra = Nombre.Split(" ").ToArray();
                if (palabra[0].Length == 2 && palabra[1].Length > 2)
                {
                    Result = true;
                }

            }
            return Result;
        }

        public static bool ValidoNombresYapellidos(string Nombre)
        {
            int Conteo = 0;
            bool Result = false;

            foreach (var item in Nombre.Split(" "))
            {
                Conteo++;
            }
            if (Conteo == 1)
            {
                Result = true;
            }
            return Result;

        }

        public static bool ValidoPalabrasQueNoFinalicenConPunto(string Nombre)
        {
            bool Result = false;
            var Palabra = Nombre.Split(" ").ToList();

            foreach (var item in Palabra)
            {
                if (item.Length > 2 && item.Contains(".") == true)
                {
                    Result = true;
                }
            }

            return Result;
        }
        /// <summary>
        /// metodo que verifica si el las inciales terminan en punto
        /// </summary>
        /// <param name="Nombre"></param>
        /// <returns></returns>
        public static bool ValidarPuntoEnIniciales(string Nombre)
        {
            bool Result = false;

            var Arreglo = Nombre.Split(" ");
            for (int i = 0; i < Arreglo.Length; i++)
            {
                //si recupero un maximo de un caracter significa que no trajo el caracter del "punto". 
                if (Arreglo[i].Length == 1)
                {
                    Result = true;
                    break;
                }
            }
            return Result;

        }
        /// <summary>
        /// valido si el primer caracter de la palabra empieza con mayuscula
        /// </summary>
        /// <param name="Nombre"></param>
        /// <returns></returns>
        public static bool ValidoMayusculas(string Nombre)
        {
            bool Result = false;

            var Arreglo = Nombre.Split(" ");
            for (int i = 0; i < Arreglo.Length; i++)
            {
                var PrimeraLetra = Arreglo[i].Substring(0, 1);

                if (PrimeraLetra != PrimeraLetra.ToUpper())
                {
                    Result = true;
                    break;
                }
            }
            return Result;
        }

        public static bool ValidoApellidoCompleto(string Nombre)
        {
            bool Result = false;
            var Arreglo = Nombre.Split(" ");
            var UltimaPalabra = Arreglo.Last();
            if (UltimaPalabra.Length == 2)
            {
                Result = true;
            }

            return Result;

        }
    }
}

