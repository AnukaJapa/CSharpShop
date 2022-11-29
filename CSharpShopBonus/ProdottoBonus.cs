using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShopBonus
{
    public class ProdottoBonus
    {

        private int codice;
        private string nome = "prodotto";
        private string descrizione;
        private int prezzo;
        private int iva;

        public ProdottoBonus()
        {

        }
        public ProdottoBonus(int codice)
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

        public void SetDescrizione(string descrizione)
        {
            this.descrizione = descrizione;
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
            return prezzo * iva / 100;
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
