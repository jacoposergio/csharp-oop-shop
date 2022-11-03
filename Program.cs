// See https://aka.ms/new-console-template for more information

//Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce i prodotti dello shop. Un prodotto è caratterizzato da:
//codice(numero intero)
//nome
//descrizione
//prezzo
//iva
//Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter
//e setter ed eventuali altri metodi di “utilità” per fare in modo che:
//alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
//Il codice prodotto sia accessibile solo in lettura
//Gli altri attributi siano accessibili sia in lettura che in scrittura
//Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
//Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
//Nella vostro programma principale, testate tutte le funzionalità della classe Prodotto.
//BONUS: create un metodo che restituisca il codice con un pad left di 0 per arrivare a
//8 caratteri (ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)


Prodotto prodottoUtente = new Prodotto("televisore", 50);
prodottoUtente.SetIva(20);
prodottoUtente.Descrizione ="Samsung Series 4 UE24N4300AU UHD Smart TV61cm (24'') 1366x768px LED Wi-Fi";
prodottoUtente.Stampa();

public class Prodotto
{
    public int Codice { get;}
    public string Nome { get; set; }
    public string Descrizione { get; set; }
    public double Prezzo { get; set; }
    public double Iva { get; set; }

    public Prodotto(string nome, double prezzo)
    {
        this.Nome = nome;
        this.Prezzo = prezzo;
        Descrizione = "nessuna descrizione disponibile";
        Codice = new Random().Next(1928, 8504);
    }

    //public double PrezzoBase()
    //{
    //    return prezzo;
    //}

    public double PrezzoIva()
    {
        double prezzoConIva = Prezzo + ((Prezzo * Iva)/ 100);
        return prezzoConIva;
    }

    public string NomeEsteso()
    {
        return Codice + Nome;
    }


    public void SetPrezzo(double prezzo)
    {
        if(Prezzo < 0)
        {
            this.Prezzo = 0;
        }
        this.Prezzo = Prezzo;
    }

    public void SetIva(double Iva)
    {
        if (Iva <= 0)
        {
            this.Iva = 1;
        }
        this.Iva = Iva;
    }

    public string PadLeft()
    {
        string codiceStringa = Codice.ToString();
        int[] arrayZeri = new int[8 - codiceStringa.Length];

        for(int i = 0; i < arrayZeri.Length; i++)
        {
            codiceStringa = '0' + codiceStringa;
        }

        return codiceStringa;
    }
    public void Stampa()
    {
        Console.WriteLine("codice: " + Codice);
        Console.WriteLine("nome: " + Nome);
        Console.WriteLine("descrizione: " + Descrizione);
        Console.WriteLine("prezzo: " + Prezzo + " euro");
        Console.WriteLine("iva: " + Iva + "%");
        Console.WriteLine("prezzo con iva: " + PrezzoIva() + " euro");
        Console.WriteLine("nome esteso: " + NomeEsteso() );
        Console.WriteLine("il codice completo è: " + PadLeft());
    }


}


