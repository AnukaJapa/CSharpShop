// See https://aka.ms/new-console-template for more information

using CSharpShop;

Random random= new Random();
int numeroRandom = random.Next(0, 1000);

Prodotto product1 = new Prodotto(numeroRandom);
Console.WriteLine("nomeEsteso : " + product1.GetNomeEsteso());
//adesso cambiare il nome:
product1.SetNome("NewName");
Console.WriteLine("il nome del prodotto esteso è: "+ product1.GetNomeEsteso());
// set iva
product1.SetIva(22);
Console.WriteLine("iva del prodotto è:"+product1.GetIva());
//set descrizione
product1.SetDescrizione("Tv Cable");

Console.WriteLine("descirizone del prodotto è: "+ product1.GetDescrizione());
//set prezzo
product1.SetPrezzo(23);

Console.WriteLine("prezzo senza iva : " + product1.GetPrezzoSenzaIva());
Console.WriteLine($"prezzo con iva è {product1.GetPrezzoConIva()}");



