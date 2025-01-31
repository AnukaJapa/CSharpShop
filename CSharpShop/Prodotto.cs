﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop
{
    public class Prodotto
    {
        private int codice; 
        private string nome = "prodotto";
        private string descrizione;
        private int prezzo;
        private int iva;

        public Prodotto()
        {

        }
        public Prodotto(int codice)
        {
            this.codice = codice;
        }

        public int GetCodice()
        {
            return codice;
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

        public void SetNome(string nome) {

            this.nome = nome;
        }

        public void SetDescrizione(string descrizione)
        {
            this.descrizione= descrizione;
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
            return prezzo*iva/100 ;
        }

        public string GetNomeEsteso()
        {
            return nome + codice;
        }
    }
}
