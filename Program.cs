//In questo esercizio dovrete leggere un file CSV (che vi allego), non tanto differente da quanto visto nel live-coding in classe,
//e salvare tutti gli indirizzi contenuti al sul interno all’interno di una lista di oggetti istanziati
//Attenzione: gli ultimi 3 indirizzi presentano dei possibili “casi particolari” 
//che possono accadere a questo genere di file: vi chiedo di pensarci e di gestire 
//come meglio crediate queste casistiche.


using ListaIndirizzi;


StreamReader fileRead = File.OpenText(@"C:\Users\Utente\source\repos\ListaIndirizzi\addresses.csv");

Console.WriteLine(fileRead.ReadLine());



List<Indirizzo> indirizzi = new List<Indirizzo>();
List<string> corString = new List<string>();

while (!fileRead.EndOfStream)
{
    string indirizzoSingolo = fileRead.ReadLine();
    //Console.WriteLine(indirizzoSingolo);

    string[] data = indirizzoSingolo.Split(",");
    try
    {

        string nome = data[0];
        string cognome = data[1];
        string via = data[2];
        string citta = data[3];
        string provincia = data[4];
        string zipString = data[5];

        try
        {
            int zip = int.Parse(data[5]);
        }
        catch (FormatException e)
        {
            zipString = "---";
        }

        Indirizzo indirizzo = new Indirizzo(nome, cognome, via, citta, provincia, zipString);
        indirizzi.Add(indirizzo);
    }
    catch (IndexOutOfRangeException e)
    {
        corString.Add(indirizzoSingolo);
    }
    foreach (Indirizzo indirizzo in indirizzi)
    {
        Console.WriteLine();
        Console.WriteLine(indirizzo.MostraIndirizzi());

    }
    foreach (string stringaErrata in corString)
    {
        Console.WriteLine("***** Stringa Errata *****");
        Console.WriteLine();
        Console.WriteLine(stringaErrata);
    }
}
fileRead.Close();







