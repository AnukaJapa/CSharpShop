// See https://aka.ms/new-console-template for more information

using CSharpShopBonus;
Random random = new Random();
int randomNumber = random.Next(0, 1000);
ProdottoBonus product1 = new ProdottoBonus(randomNumber);



Console.WriteLine($@" --------------------------

this is codice with pad:{ product1.PadMethod()}

-----------------------------");


//creazione dei prodotti nello shop
ProdottoBonus product2 = new ProdottoBonus(random.Next(0, 1000),10,50);
ProdottoBonus product3 = new ProdottoBonus(random.Next(0, 1000),20,50);
ProdottoBonus product4 = new ProdottoBonus(random.Next(0, 1000),30,50);
ProdottoBonus product5 = new ProdottoBonus(random.Next(0, 1000),40,50);


List<ProdottoBonus> products = new List<ProdottoBonus>()
{
    product1,
    product2,
    product3,
    product4,
};

products.Add(product5);
product1.SetPrezzo(20);
product1.SetIva(50);



foreach(ProdottoBonus product in products)
{
    Console.WriteLine(product.GetDescrizione());
}



