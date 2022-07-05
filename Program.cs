//In questo esercizio dovrete leggere un file CSV (che vi allego), non tanto differente da quanto visto nel live-coding in classe,
//e salvare tutti gli indirizzi contenuti al sul interno all’interno di una lista di oggetti istanziati
//a partire dalla classe Indirizzo.
using ListaIndirizzi;

StreamReader file = File.OpenText("C:/Users/Utente/source/repos/ListaIndirizzi/addresses.csv");


while (!file.EndOfStream)
{

    string line = file.ReadLine();
    Console.WriteLine(line);
}
file.Close();

