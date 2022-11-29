// See https://aka.ms/new-console-template for more information

using CSharpShopBonus;

Random random = new Random();
int randomNumber =  random.Next(0,1000);

ProdottoBonus product1 = new ProdottoBonus(randomNumber);
Console.WriteLine("this is codice with pad: "+ product1.PadMethod());