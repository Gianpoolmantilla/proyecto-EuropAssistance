using System;
using System.Linq;
using System.Collections.Generic;

namespace DesafioTecnico
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //ejemplos

            Desafio _desafio = new Desafio();

            Console.WriteLine("SIMPLIFICO");
            Console.WriteLine(_desafio.Simplificar("4/6"));
            Console.WriteLine(_desafio.Simplificar("10/11"));
            Console.WriteLine(_desafio.Simplificar("100/400"));

            Console.WriteLine("VALIDO NOMBRE\n");
            _desafio.ValidoNombre("E. Poe");
            _desafio.ValidoNombre("E. A. Poe");
            _desafio.ValidoNombre("Edgard A. Poe");
            _desafio.ValidoNombre("Edgard");
            _desafio.ValidoNombre("e. Poe");
            _desafio.ValidoNombre("E Poe");
            _desafio.ValidoNombre("E. Allan Poe");
            _desafio.ValidoNombre("E. Allan P.");
            _desafio.ValidoNombre("Edg. Allan Poe");
            Console.ReadLine();
        }

        

    }
}
