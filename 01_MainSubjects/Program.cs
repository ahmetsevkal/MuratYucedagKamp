Console.WriteLine("Hello, World!");
Console.Write("Merhaba Dünya");

#region Food Categories
//Console.WriteLine("******Food Categories********");
//Console.WriteLine();
//Console.WriteLine("Soups");
//Console.WriteLine("Main Course");
//Console.WriteLine("Salads");
//Console.WriteLine("Sweets");
//Console.WriteLine("Bavareges");
//Console.WriteLine();
//Console.WriteLine("******Food Categories********");
#endregion

#region String_Variables
string customerName = "Ahmet",
       customerSurname = "SEVKAL",
       customerPhone = "+90000000000",
       customerEmail = "aaaa@gmail.com",
       district = "Bodrum",
       city = "Muğla";


Console.WriteLine("*****Rezervasyon Kartı******");
Console.WriteLine("");
Console.WriteLine("Müşteri" + customerName + " " + customerSurname);
Console.WriteLine("İletişim:" + customerPhone + " " + customerEmail);
Console.WriteLine("Adres :" + district + "/" + city);

#endregion

#region Int_Variables
int hamburgerPrice = 300,
    cokePrice = 35,
    waterPrice = 10,
    friesPrice = 50,
    pizzaPrice = 250,
    lemonadePrice = 30;

Console.WriteLine("*****Fiyat Listesi*****");
Console.WriteLine("");
Console.WriteLine("-----Hamburger: "+ hamburgerPrice+" TL");
Console.WriteLine("-----Coke: " + cokePrice + " TL");
Console.WriteLine("-----Water: " + waterPrice + " TL");
Console.WriteLine("-----Fries: " + friesPrice+ " TL");
Console.WriteLine("-----Pizza: " + pizzaPrice + " TL");
Console.WriteLine("-----Lemonade: " + lemonadePrice + " TL");
Console.WriteLine("*****Fiyat Listesi*****");


int hamburgerCount=3, cokeCount=3, waterCount=3, friesCount=1, pizzaCount=0, lemonadeCount=0, total=0;
total = (hamburgerCount * hamburgerPrice) + (cokeCount * cokePrice) + (waterCount * waterPrice) + (friesCount * friesPrice) + (pizzaCount * pizzaPrice) + (lemonadeCount * lemonadePrice);
Console.WriteLine("Ödenecek Toplam Tutar: "+ total+ " TL");





#endregion