﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShopBonus
{
    public class ProdottoBonus
    {
        private int codice;
        private string nome;
        private string descrizione;
        private int prezzo;
        private int iva;

        public ProdottoBonus()
        {

        }
        public ProdottoBonus(int codice, string nome = "prodotto")
        {
            this.nome = nome;
            this.codice = codice;
        }
        public ProdottoBonus(int codice, int prezzo, int iva, string nome="prodotto")
        {
            this.nome = nome;
            this.codice = codice;
            this.prezzo = prezzo;
            this.iva = iva;
        }

        public int GetCodice()
        {
            return this.codice;
        }

        public string GetPrezzoSenzaIva()
        {
            return prezzo + "€";
        }

        public string GetDescrizione()
        {
            int prezzoSenzaIva = this.prezzo;
            int prezzoConIva = this.GetPrezzoConIva();
            

            this.descrizione = $@" 
    nome del Prodotto: {this.nome + this.codice}
    codice: {this.codice}
    prezzo del Prodotto: {prezzoSenzaIva}
    prezzo con Iva: {prezzoConIva}
    iva: {this.iva}

-----------------------------------------------------
";

            return descrizione;
        }

        public string GetNome()
        {
            return nome;
        }
        public string GetIva()
        {
            return iva + "%";
        }

        public void SetNome(string nome)
        {

            this.nome = nome;
        }

        public void SetPrezzo(int prezzo)
        {
            this.prezzo = prezzo;
        }

        public void SetIva(int iva)
        {
            this.iva = iva;
        }

        public int GetPrezzoConIva()
        {
            int prezzoConIva = this.prezzo + (this.prezzo * this.iva / 100);
            return prezzoConIva;
        }

        public string GetNomeEsteso()
        {
            return nome + codice;
        }

        public string PadMethod()
        {
            string codiceStringaPad = this.codice.ToString();

            for(int i = codiceStringaPad.Length; i<8; i++)
            {
                codiceStringaPad = "0" + codiceStringaPad;
            }
            return codiceStringaPad;
        }

    }
}
