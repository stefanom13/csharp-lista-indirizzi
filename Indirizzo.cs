using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaIndirizzi
{
    public class Indirizzo
    {

        public string nome = "";
        public string cognome = "";
        public string via = "";
        public string citta = "";
        public string provincia = "";
        public string Zip;



        public Indirizzo(string nome, string cognome, string via, string citta, string provincia, string zip)
        {
         this.nome = nome;
         this.cognome = cognome;
         this.via = via;
         this.citta = citta;
         this.provincia = provincia;
         this.Zip = zip;

        }
        public string MostraIndirizzi()
        {
            string descrizione = $"******Address List ******\n" +
                    $"Name: {nome}\n" +
                    $"Surname: {cognome}\n" +
                    $"Street: {via}\n" +
                    $"City: {citta}\n" +
                    $"Province: {provincia}\n" +
                    $"Zip: {Zip}\n" +
            "******";

            return descrizione;
        }
        
    }
}
