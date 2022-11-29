using System;
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
        private string nome;
        private string descrizione;
        private int prezzo;
        private string iva;

        
        public Prodotto()
        {

        }
        public Prodotto(int codice)
        {
            this.codice = codice;
        }

        public int getCodice()
        {
            return codice;
        }




    }
}
