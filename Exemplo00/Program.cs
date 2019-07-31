using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo00
{
    class Program
    {
        static void Main(string[] args)
        {
            SistemaContext contexto = new SistemaContext();
            Animal animal = new Animal();
            animal.Nome = "T-Rex";
            animal.Extinto = true;

            contexto.Animais.Add(animal);
            contexto.SaveChanges();
            Console.WriteLine("Registro salvo com sucesso");

        }
    }
}
