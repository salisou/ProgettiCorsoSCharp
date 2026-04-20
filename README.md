# Corso di programmazione in c#

Modifica con l'app Documenti
Effettua gli ultimi ritocchi, inserisci commenti e condividi con altre persone per apportare modifiche contemporaneamente.
NO, GRAZIEUSA L'APP

Corso Completo di C# per Principianti – Da 0 a Programmatore

Corso Completo di C# per Principianti – Da 0 a Programmatore
Docente: Moussa

MODULO 1 – Introduzione a C#
C# (si legge “si sharp”) è un linguaggio di programmazione creato da Microsoft.
Serve per creare programmi per Windows, giochi con Unity, app web e tanto altro.

Per scrivere in C# usiamo di solito Visual Studio o Visual Studio Code.
I file del codice finiscono con .cs (come Program.cs).



MODULO 2 – Il tuo primo programma
Qui stampiamo un messaggio sullo schermo per la prima volta.


using System;  // Serve per accedere a funzioni base come Console


class Program   // Definisce una classe chiamata Program

{

    static void Main()  // Metodo principale: da qui parte il programma

    {

        Console.WriteLine("Ciao, mondo!");  // Stampa un messaggio a schermo

    }

}



Spiegazione passo passo:

using System; → Importa la libreria “System” per usare funzioni base.
class Program → Crea un contenitore per il tuo codice.
static void Main() → Il punto di partenza di ogni programma C#.
Console.WriteLine() → Scrive un testo e va a capo.


MODULO 3 – Variabili e tipi di dati
Qui impariamo a memorizzare informazioni come numeri o testi.


int eta = 14;              // Numero intero

string nome = "Moussa";    // Testo

float altezza = 1.70f;     // Numero decimale

bool studente = true;      // Vero o falso



Spiegazione passo passo:

int → per numeri interi (es. 5, 20, 100)
string → per testi
float → per numeri con la virgola
bool → per valori veri/falsi
Esempio d’uso:


Console.WriteLine("Mi chiamo " + nome + " e ho " + eta + " anni.");



MODULO 4 – Input da tastiera
Qui facciamo scrivere qualcosa all’utente e leggiamo la risposta.

Spiegazione:

Console.Write() → scrive senza andare a capo
Console.ReadLine() → legge ciò che l’utente scrive e preme invio


MODULO 5 – Operazioni matematiche
Qui impariamo a sommare, sottrarre, moltiplicare e dividere numeri.


int a = 5;

int b = 3;


int somma = a + b;

int differenza = a - b;

int prodotto = a * b;

int divisione = a / b;


Console.WriteLine("Somma: " + somma);

Console.WriteLine("Differenza: " + differenza);

Console.WriteLine("Prodotto: " + prodotto);

Console.WriteLine("Divisione: " + divisione);


Spiegazione:

Ogni operazione crea una nuova variabile con il risultato.

Puoi anche usare i numeri direttamente:


Console.WriteLine(10 + 5);  // Stampa 15




MODULO 6 – Condizioni (if / else)
Qui prendiamo decisioni in base a una condizione logica.


Console.Write("Quanti anni hai? ");

int eta = int.Parse(Console.ReadLine());  // Converte il testo in numero


if (eta >= 18)

{

    Console.WriteLine("Sei maggiorenne!");

}

else

{

    Console.WriteLine("Sei minorenne!");

}


Spiegazione:

if → controlla se una condizione è vera
else → esegue un’altra azione se è falsa
int.Parse() → converte il testo (stringa) in numero intero

MODULO 7 – Ciclo while
Qui ripetiamo qualcosa finché una condizione è vera.


int i = 1;


while (i <= 5)   // Finché i è minore o uguale a 5

{

    Console.WriteLine("Numero: " + i);  // Stampa il numero

    i++;  // Aumenta i di 1

}


Spiegazione:
         Questo ciclo stampa i numeri da 1 a 5.
        La riga i++ equivale a i = i + 1.


MODULO 8 – Ciclo for
Un altro modo per ripetere istruzioni un certo numero di volte.


for (int i = 1; i <= 5; i++)

{

    Console.WriteLine("Valore di i: " + i);

}


Spiegazione:

for contiene 3 parti:
int i = 1 → parte da 1
i <= 5 → continua finché i ≤ 5
i++ → aumenta di 1 ogni giro

MODULO 9 – Array (insiemi di valori)
Qui impariamo a salvare più dati insieme, come una lista di nomi.


string[] nomi = { "Moussa", "Giulia", "Luca" };


Console.WriteLine("Il primo nome è: " + nomi[0]);  // Mostra "Moussa"

Console.WriteLine("Il secondo nome è: " + nomi[1]);


Spiegazione:

Gli indici partono da 0, quindi nomi[0] è il primo elemento.

Puoi anche scorrerli con un ciclo:


for (int i = 0; i < nomi.Length; i++)

{

    Console.WriteLine("Nome: " + nomi[i]);

}




MODULO 10 – Funzioni (metodi)
Le funzioni servono per organizzare il codice in “blocchi di lavoro”.


static void Saluta(string nome)

{

    Console.WriteLine("Ciao " + nome + "!");

}


static void Main()

{

    Saluta("Moussa");

    Saluta("Giulia");

}


Spiegazione:

static void Saluta(string nome) → definisce una funzione che riceve un testo (nome)
Saluta("Moussa") → chiama la funzione
Ti permette di riutilizzare il codice invece di scrivere le stesse righe più volte

Fine della Parte 1 (Livello Base)

PARTE 2 – LIVELLO INTERMEDIO

MODULO 11 – Gestione degli errori (try / catch)
Qui impariamo a gestire gli errori, così il programma non si blocca se l’utente scrive qualcosa di sbagliato.


try

{

    Console.Write("Inserisci un numero: ");           // Chiede un numero

    int numero = int.Parse(Console.ReadLine());       // Prova a convertirlo in int

    Console.WriteLine("Hai inserito: " + numero);     // Mostra il numero

}

catch

{

    Console.WriteLine("Ops! Hai scritto qualcosa che non è un numero!");  // Messaggio di errore

}


Spiegazione:

Il blocco try contiene il codice “a rischio”.
Se si verifica un errore, il programma salta nel catch e mostra un messaggio.
Questo evita che il programma si chiuda improvvisamente.

MODULO 12 – Lavorare con i file
Qui impariamo a scrivere e leggere dati da un file di testo .txt.

Scrivere un file:

using System.IO;  // Serve per gestire i file


File.WriteAllText("dati.txt", "Ciao! Questo è un testo salvato da C#!");  // Crea o sovrascrive un file

Console.WriteLine("File creato con successo!");  // Conferma


Leggere un file:


string contenuto = File.ReadAllText("dati.txt");  // Legge tutto il testo del file

Console.WriteLine("Contenuto del file: " + contenuto);  // Mostra il contenuto


Spiegazione:

File.WriteAllText() → scrive testo nel file.
File.ReadAllText() → legge il contenuto e lo restituisce come stringa.

MODULO 13 – Liste (più flessibili degli array)
Qui scopriamo come usare una lista, che può crescere o ridursi dinamicamente.


using System;

using System.Collections.Generic;  // Necessario per usare le liste


List<string> nomi = new List<string>();  // Crea una lista di stringhe


nomi.Add("Moussa");   // Aggiunge un nome

nomi.Add("Giulia");

nomi.Add("Luca");


foreach (string nome in nomi)  // Scorre tutta la lista

{

    Console.WriteLine("Ciao " + nome + "!");

}


Spiegazione:

List<T> è una lista generica: T indica il tipo (qui string).
Add() → aggiunge un elemento.
foreach → serve per scorrere tutti gli elementi.

MODULO 14 – Menu interattivi in console
Creiamo un semplice menu testuale per gestire più azioni.


using System;

using System.Collections.Generic;


class Program

{

    static void Main()

    {

        List<string> nomi = new List<string>();  // Lista dei nomi

        bool esci = false;                       // Controllo del ciclo


        while (!esci)

        {

            Console.WriteLine("\n--- MENU ---");

            Console.WriteLine("1. Aggiungi nome");

            Console.WriteLine("2. Mostra tutti");

            Console.WriteLine("3. Esci");

            Console.Write("Scegli un'opzione: ");

            string scelta = Console.ReadLine();


            if (scelta == "1")

            {

                Console.Write("Inserisci un nome: ");

                string nome = Console.ReadLine();

                nomi.Add(nome);

                Console.WriteLine("Nome aggiunto!");

            }

            else if (scelta == "2")

            {

                Console.WriteLine("\nEcco i nomi salvati:");

                foreach (string n in nomi)

                    Console.WriteLine("- " + n);

            }

            else if (scelta == "3")

            {

                esci = true;  // Uscita dal ciclo

            }

            else

            {

                Console.WriteLine("Scelta non valida!");

            }

        }


        Console.WriteLine("Programma terminato!");

    }

}


Spiegazione:

Usa un ciclo while per far ripetere il menu.
Le scelte vengono lette come testo (string).
Se l’utente digita 3, il programma esce.

MODULO 15 – Classi con costruttori
Ora impariamo a costruire oggetti con più informazioni (es. studenti).


class Studente

{

    public string Nome;     // Nome dello studente

    public int Eta;         // Età

    public string Corso;    // Corso di studio


    public Studente(string nome, int eta, string corso)  // Costruttore

    {

        Nome = nome;

        Eta = eta;

        Corso = corso;

    }


    public void MostraInfo()  // Metodo per mostrare le info

    {

        Console.WriteLine($"Studente: {Nome}, {Eta} anni, corso: {Corso}");

    }

}


class Program

{

    static void Main()

    {

        Studente s1 = new Studente("Moussa", 14, "Informatica");  // Crea un nuovo studente

        s1.MostraInfo();  // Chiama il metodo per mostrare i dati

    }

}


Spiegazione:

Il costruttore serve per impostare subito i valori di un oggetto.
public void MostraInfo() → è un metodo che mostra i dettagli.

MODULO 16 – Progetto pratico: Gestore studenti
Creiamo un mini software per aggiungere, visualizzare e salvare studenti.


using System;

using System.Collections.Generic;

using System.IO;


class Studente

{

    public string Nome;

    public int Eta;

    public string Corso;


    public Studente(string nome, int eta, string corso)

    {

        Nome = nome;

        Eta = eta;

        Corso = corso;

    }


    public override string ToString()  // Rappresentazione in testo

    {

        return $"{Nome} - {Eta} anni - {Corso}";

    }

}


class Program

{

    static List<Studente> studenti = new List<Studente>();  // Lista studenti


    static void Main()

    {

        bool esci = false;


        while (!esci)

        {

            Console.WriteLine("\n--- GESTORE STUDENTI ---");

            Console.WriteLine("1. Aggiungi studente");

            Console.WriteLine("2. Mostra studenti");

            Console.WriteLine("3. Salva su file");

            Console.WriteLine("4. Esci");

            Console.Write("Scegli: ");

            string scelta = Console.ReadLine();


            switch (scelta)

            {

                case "1":

                    AggiungiStudente();

                    break;

                case "2":

                    MostraStudenti();

                    break;

                case "3":

                    SalvaSuFile();

                    break;

                case "4":

                    esci = true;

                    break;

                default:

                    Console.WriteLine("Scelta non valida!");

                    break;

            }

        }

    }


    static void AggiungiStudente()

    {

        Console.Write("Nome: ");

        string nome = Console.ReadLine();

        Console.Write("Età: ");

        int eta = int.Parse(Console.ReadLine());

        Console.Write("Corso: ");

        string corso = Console.ReadLine();


        studenti.Add(new Studente(nome, eta, corso));  // Aggiunge lo studente

        Console.WriteLine("Studente aggiunto!");

    }


    static void MostraStudenti()

    {

        Console.WriteLine("\nLista studenti:");

        foreach (Studente s in studenti)

            Console.WriteLine("- " + s);

    }


    static void SalvaSuFile()

    {

        List<string> righe = new List<string>();

        foreach (Studente s in studenti)

            righe.Add(s.ToString());


        File.WriteAllLines("studenti.txt", righe);  // Salva tutti gli studenti nel file

        Console.WriteLine("File salvato come 'studenti.txt'!");

    }

}


Spiegazione:

Gli studenti vengono salvati in una lista.
Si possono aggiungere, visualizzare o salvare su file.
Il metodo ToString() decide come un oggetto viene mostrato a schermo.

Fine della Parte 2 (Livello Intermedio)


PARTE 3 – LIVELLO AVANZATO

MODULO 17 – Proprietà (Properties)
Le proprietà servono per controllare come i dati vengono letti o modificati in una classe.


class Persona

{

    private string nome;   // Variabile privata (non accessibile dall’esterno)


    public string Nome     // Proprietà pubblica per leggere/scrivere "nome"

    {

        get { return nome; }               // Restituisce il valore

        set { nome = value.ToUpper(); }    // Imposta il valore in maiuscolo

    }

}


class Program

{

    static void Main()

    {

        Persona p = new Persona();

        p.Nome = "moussa";   // Imposta il nome

        Console.WriteLine(p.Nome);  // Mostra "MOUSSA"

    }

}


Spiegazione:

private → variabile nascosta.
get → serve per leggere il valore.
set → serve per scriverlo.
value → rappresenta il valore assegnato.

MODULO 18 – Ereditarietà (Inheritance)
L’ereditarietà permette a una classe di “ereditare” proprietà e metodi da un’altra classe.


class Animale

{

    public void Mangia()

    {

        Console.WriteLine("L'animale sta mangiando...");

    }

}


class Cane : Animale  // "Cane" eredita da "Animale"

{

    public void Abbaia()

    {

        Console.WriteLine("Il cane abbaia!");

    }

}


class Program

{

    static void Main()

    {

        Cane mioCane = new Cane();

        mioCane.Mangia();  // Metodo ereditato

        mioCane.Abbaia();  // Metodo proprio

    }

}


Spiegazione:

class Cane : Animale → “Cane” eredita tutto da “Animale”.
In questo modo riutilizzi codice senza riscriverlo.

MODULO 19 – Interfacce
Un’interfaccia è come un contratto: dice quali metodi una classe deve avere, ma non come.


interface IVeicolo

{

    void Muovi();  // Metodo obbligatorio

}


class Auto : IVeicolo

{

    public void Muovi()

    {

        Console.WriteLine("L'auto si sta muovendo!");

    }

}


class Bicicletta : IVeicolo

{

    public void Muovi()

    {

        Console.WriteLine("La bicicletta sta pedalando!");

    }

}


class Program

{

    static void Main()

    {

        IVeicolo v1 = new Auto();

        IVeicolo v2 = new Bicicletta();


        v1.Muovi();

        v2.Muovi();

    }

}


Spiegazione:

Le interfacce permettono di scrivere codice “generico”.
Ogni classe che implementa l’interfaccia deve rispettare il contratto.

MODULO 20 – LINQ (Language Integrated Query)
LINQ serve per fare ricerche e filtri in modo semplice su liste o array.


using System;

using System.Linq;  // Necessario per usare LINQ


class Program

{

    static void Main()

    {

        int[] numeri = { 1, 2, 3, 4, 5, 6, 7, 8 };


        var numeriPari = from n in numeri

                         where n % 2 == 0

                         select n;


        Console.WriteLine("Numeri pari:");

        foreach (var n in numeriPari)

            Console.WriteLine(n);

    }

}


Spiegazione:

from ... in ... where ... select ... → stile simile all’inglese naturale.
where n % 2 == 0 → seleziona solo i numeri pari.

MODULO 21 – Programmazione asincrona (async / await)
Serve per eseguire operazioni “in parallelo”, senza bloccare il programma.


using System;

using System.Threading.Tasks;


class Program

{

    static async Task Main()

    {

        Console.WriteLine("Inizio operazione...");

        await LavoroLungo();  // Attende il completamento

        Console.WriteLine("Operazione completata!");

    }


    static async Task LavoroLungo()

    {

        await Task.Delay(2000);  // Attende 2 secondi (simula un lavoro lungo)

        Console.WriteLine("Lavoro finito!");

    }

}


Spiegazione:

async → indica un metodo asincrono.
await → dice al programma di aspettare senza bloccare tutto.
Task.Delay() → simula un’attesa.

MODULO 22 – Classi statiche e metodi statici
Le classi statiche servono per creare funzioni “universali” che non richiedono oggetti.


static class Matematica

{

    public static int Somma(int a, int b)

    {

        return a + b;

    }


    public static int Quadrato(int x)

    {

        return x * x;

    }

}


class Program

{

    static void Main()

    {

        Console.WriteLine(Matematica.Somma(3, 5));

        Console.WriteLine(Matematica.Quadrato(4));

    }

}


Spiegazione:

Non serve creare un oggetto (new).
I metodi statici possono essere richiamati direttamente dalla classe.

MODULO 23 – Progetto finale: Gioco del Tris (Tic-Tac-Toe)
Costruiamo insieme un piccolo gioco completo da console.


using System;


class Tris

{

    static char[] caselle = { '1','2','3','4','5','6','7','8','9' };

    static int giocatore = 1;  // 1 = X, 2 = O

    static int scelta;

    static char segno;


    static void Main()

    {

        int vincitore = 0;


        do

        {

            Console.Clear();

            DisegnaTavola();

            Console.WriteLine($"Giocatore {(giocatore == 1 ? "X" : "O")}, scegli una casella: ");

            scelta = int.Parse(Console.ReadLine());

            segno = (giocatore == 1) ? 'X' : 'O';


            if (caselle[scelta - 1] != 'X' && caselle[scelta - 1] != 'O')

            {

                caselle[scelta - 1] = segno;

                giocatore = (giocatore == 1) ? 2 : 1;

            }

            else

            {

                Console.WriteLine("Casella già occupata!");

                Console.ReadKey();

            }


            vincitore = ControllaVittoria();


        } while (vincitore == 0);


        Console.Clear();

        DisegnaTavola();


        if (vincitore == 1)

            Console.WriteLine($"🎉 Giocatore {(giocatore == 2 ? "X" : "O")} ha vinto!");

        else

            Console.WriteLine("😅 Pareggio!");

    }


    static void DisegnaTavola()

    {

        Console.WriteLine("-------------");

        for (int i = 0; i < 9; i += 3)

        {

            Console.WriteLine($"| {caselle[i]} | {caselle[i + 1]} | {caselle[i + 2]} |");

            Console.WriteLine("-------------");

        }

    }


    static int ControllaVittoria()

    {

        int[,] combinazioni =

        {

            {0,1,2}, {3,4,5}, {6,7,8},  // Righe

            {0,3,6}, {1,4,7}, {2,5,8},  // Colonne

            {0,4,8}, {2,4,6}             // Diagonali

        };


        for (int i = 0; i < combinazioni.GetLength(0); i++)

        {

            if (caselle[combinazioni[i, 0]] == caselle[combinazioni[i, 1]] &&

                caselle[combinazioni[i, 1]] == caselle[combinazioni[i, 2]])

            {

                return 1; // Vittoria

            }

        }


        // Controlla pareggio

        for (int i = 0; i < caselle.Length; i++)

        {

            if (caselle[i] != 'X' && caselle[i] != 'O')

                return 0;

        }


        return -1; // Pareggio

    }

}


Spiegazione:

Usa array per memorizzare le caselle.
Ogni turno cambia il giocatore.
La funzione ControllaVittoria() controlla tutte le combinazioni possibili.
Puoi giocarlo direttamente nella console! 🎮

