using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaIndirizzi
{
    internal class Indirizzo
    {
        // Nome,Cognome,Via,Città,Provincia,ZIP
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Via { get; set; }
        public string Città { get; set; }
        public string Provincia { get; set; }
        public int ZIP { get; set; }


        public Indirizzo(string nome, string cognome, string città, string via, string provincia, int zip)
        {
            Nome = nome;
            Cognome = cognome;
            Città = città;
            Via = via;
            Provincia = provincia;
            ZIP = zip;
        }

        public void ToString()
        {
            Console.WriteLine("\n* INDIRIZZO: *");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Cognome: {Cognome}");
            Console.WriteLine($"Via: {Via}");
            Console.WriteLine($"Città: {Città}");
            Console.WriteLine($"Provincia: {Provincia}");
            Console.WriteLine($"ZIP: {ZIP}");
        }
    }
}
