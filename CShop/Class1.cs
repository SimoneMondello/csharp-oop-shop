using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShop
{
    internal class prodotto
    {
        private int Codice;
        private string Nome;
        private string Descrizione;
        private int Prezzo;
        private int Iva;

        public prodotto(int codice, string nome, int prezzo, string descrizione, int iva)
        {
            this.Codice = codice;
            this.Nome = nome;
            this.Descrizione = descrizione;
            this.Iva = iva;


        }
        public int NumeroCasuale()
            {
            Random r = new Random();
            return r.Next(100000000);
            }
        public double CalcoloPrezzoIva()
        {
            double ivato = Prezzo * Iva;
            double prezzoFinale = Prezzo + ivato / 100;
            return prezzoFinale ;
            Console.WriteLine("Prezzo finale " +prezzoFinale + ivato);
        }
        public void iva()
        {
            double Iva = 22 % Prezzo;
        }
        public void prezzo ()
        {
            Prezzo = 10;
        }
        public void StampaCodice()
        {
            Console.WriteLine ("Nome prodotto "+ NumeroCasuale() + Nome);
        }
    }



   
}
