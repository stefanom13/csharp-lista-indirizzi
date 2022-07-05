//In questo esercizio dovrete leggere un file CSV (che vi allego), non tanto differente da quanto visto nel live-coding in classe,
//e salvare tutti gli indirizzi contenuti al sul interno all’interno di una lista di oggetti istanziati
//Attenzione: gli ultimi 3 indirizzi presentano dei possibili “casi particolari” 
//che possono accadere a questo genere di file: vi chiedo di pensarci e di gestire 
//come meglio crediate queste casistiche.


using ListaIndirizzi;


StreamReader fileRead = File.OpenText(@"C:\Users\Utente\source\repos\ListaIndirizzi\addresses.csv");

Console.WriteLine(fileRead.ReadLine());



List<Indirizzo> indirizzi = new List<Indirizzo>();







