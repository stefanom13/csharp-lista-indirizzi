using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaIndirizzi
{
    internal class Indirizzo
    {
       
            public string Nome { get; set; }
            public string Cognome{ get; set; }
            public string Via { get; set; }
            public string Citta { get; set; }
            public string Provincia { get; set; }
            public string Zip { get; set; }


            public Indirizzo(string nome, string cognome, string via, string citta, string provincia, string zip)
            {
                Nome = nome;
                Cognome = cognome;
                Via = via;
                Citta = citta;
                Provincia = provincia;
                Zip = zip;

            }
            public Indirizzo() { }

            public void MostraIndirizzi()
            {
                Console.Write("\n--- Indirizzo ---\nNome {0}\nCognome {1}\nIndirizzo {2}\nCittà {3}\nProvincia {4}\n ZipCode {5}\n--------------");
            }
        
    }
}
