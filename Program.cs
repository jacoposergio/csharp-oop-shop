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
//prodottoUtente.SetDescrizione("Samsung Series 4 UE24N4300AU UHD Smart TV61cm (24'') 1366x768px LED Wi-Fi");
prodottoUtente.Stampa();

public class Prodotto
{
    private int codice;
    private string nome;
    private string descrizione;
    private double prezzo;
    private double iva;

    public Prodotto(string nome, double prezzo)
    {
        this.nome = nome;
        this.prezzo = prezzo;
        descrizione = "nessuna descrizione disponibile";
        codice = new Random().Next(1928, 8504);
    }

    public double PrezzoBase()
    {
        return prezzo;
    }

    public double PrezzoIva()
    {
        double prezzoConIva = prezzo + ((prezzo * iva)/ 100);
        return prezzoConIva;
    }

    public string NomeEsteso()
    {
        return codice + nome;
    }

    public int GetCodice()
    {
        return this.codice;
    }

    public string GetNome()
    {
        return this.nome;
    }

    public void SetNome(string nome)
    {
      this.nome = nome;
    }

    public string Getdescrizione()
    {
        return this.descrizione;
    }

    public void SetDescrizione(string descrizione)
    {
        this.descrizione = descrizione;
    }

    public double GetPrezzo()
    {
        return this.prezzo;
    }

    public void SetPrezzo(double prezzo)
    {
        if(prezzo < 0)
        {
            this.prezzo = 0;
        }
        this.prezzo = prezzo;
    }

    public double GetIva()
    {      
        return this.iva;
    }

    public void SetIva(double iva)
    {
        if (iva <= 0)
        {
            this.iva = 1;
        }
        this.iva = iva;
    }

    public string PadLeft()
    {
        string codiceStringa = codice.ToString();
        int[] arrayZeri = new int[8 - codiceStringa.Length];

        for(int i = 0; i < arrayZeri.Length; i++)
        {
            arrayZeri[i] = 0;
        }

        string arrayZeriStringa = arrayZeri.ToString();
        string codiceCompleto = arrayZeriStringa + codiceStringa;
        return codiceCompleto;
    }
    public void Stampa()
    {
        Console.WriteLine("codice: " + codice);
        Console.WriteLine("nome: " + nome);
        Console.WriteLine("descrizione: " + descrizione);
        Console.WriteLine("prezzo: " + prezzo + " euro");
        Console.WriteLine("iva: " + iva + "%");
        Console.WriteLine("prezzo con iva: " + PrezzoIva() + " euro");
        Console.WriteLine("nome esteso: " + NomeEsteso() );
        Console.WriteLine("il codice completo è: " + PadLeft());
    }


}


