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

            //#region Inserir
            //Animal animal = new Animal();

            //animal.Nome = "T-Rex";
            //animal.Extinto = true;
           
            //contexto.Animais.Add(animal);
            //contexto.SaveChanges();
            //Console.WriteLine("Registro salvo com sucesso");
            //#endregion Inserir

            //#region Apagar
            //Animal animalApagar = contexto.Animais.Where(x => x.Nome == "Porco Aranha").First();
            //contexto.Animais.Remove(animalApagar);
            //#endregion Apagar

            //#region Alterar
            //var cachorro = contexto.Animais
            //    //.Where()
            //    .First(x => x.Id == 4);
            //#endregion Alterar;



            //List<Animal> animais = contexto.Animais
            //    .Where(x => x.Extinto == true && x.Nome.Contains("")).OrderBy(x => x.Nome).ToList();

            //foreach (Animal animal in animais)
            //{
            //    Console.WriteLine($"{animal.Id} - {animal.Nome} - {animal.Extinto} - {animal.Peso}");
            //}

            //#region InserirRelacionado
            //Habilidade habilidade = new Habilidade();
            //habilidade.IdAnimal = 1;
            //habilidade.Nome = "Invisibilidade";

            //contexto.habilidades.Add(habilidade);
            //contexto.SaveChanges();
            //Console.WriteLine(habilidade.Nome);
            //#endregion InserirRelacionado

            var habilidades = contexto.habilidades.ToList();

            foreach(Habilidade habilidadeAux in habilidades)
            {
                Console.WriteLine(habilidadeAux.Animal.Nome + "-" + habilidadeAux.Nome);
            }
        }
    }
}