
#region Double Variables 

//Console.WriteLine("******Fiyat Listesi******");
//Console.WriteLine();

//double applePrice = 14.85, orangePrice = 20.95, strawberryPrice = 45, patatoPrice = 9.74, tomatoPrice = 6.88;

//Console.WriteLine("Elma birim fiyatı " + applePrice  + " TL");
//Console.WriteLine("Portakal birim fiyatı " + orangePrice  + " TL");
//Console.WriteLine("Çilek birim fiyatı " + strawberryPrice  + " TL");
//Console.WriteLine("Patates birim fiyatı " + patatoPrice  + " TL");
//Console.WriteLine("Domates birim fiyatı " + tomatoPrice  + " TL");
//Console.WriteLine("************************");

//double appleGram, orangeGram, strawberryGram,patatoGram,tomatoGram;

//appleGram = 1.245;
//orangeGram = 2.560;
//strawberryGram = 0.750;
//patatoGram = 4.859;
//tomatoGram = 3.745;

//double appleTotalPrice = applePrice * appleGram;
//double orangeTotalPrice= orangePrice * orangeGram;
//double strawberryTotalPrice = strawberryPrice * strawberryGram;
//double  patatoTotalPrice = patatoPrice * patatoGram;
//double tomatoTotalPrice = tomatoGram * tomatoGram;
//double shoppingTotalPrice= appleTotalPrice+orangeTotalPrice+strawberryTotalPrice+tomatoTotalPrice+patatoTotalPrice;
//Console.WriteLine("Alınan ürün : Elma - " + "Birim fiyatı : " + applePrice + "- Gramaj : " + appleGram + "Toplam Tutar: "+ appleTotalPrice);
//Console.WriteLine("Alınan ürün : Portakal - " + "Birim fiyatı : " + orangePrice + "- Gramaj : " + orangeGram + "Toplam Tutar: " + orangeTotalPrice);
//Console.WriteLine("Alınan ürün : Çilek - " + "Birim fiyatı : " + strawberryPrice + "- Gramaj : " + strawberryPrice + "Toplam Tutar: " + strawberryTotalPrice);
//Console.WriteLine("Alınan ürün : Patates - " + "Birim fiyatı : " + patatoPrice + "- Gramaj : " + patatoGram + "Toplam Tutar: " + patatoTotalPrice);
//Console.WriteLine("Alınan ürün : Domates - " + "Birim fiyatı : " + tomatoPrice + "- Gramaj : " + tomatoGram + "Toplam Tutar: " + tomatoTotalPrice);
//Console.WriteLine("************************");
//Console.WriteLine("");
//Console.WriteLine("");

//Console.WriteLine("Toplam alışveriş tutarı : "+shoppingTotalPrice+" TL");


#endregion
#region Char_Variables
//char cr = 'a';
//Console.WriteLine(cr);

#endregion
#region Inputs


//Console.WriteLine("*******C# Hava Yolları*******");
//Console.WriteLine();
//string passangerId, passangerName, passangerSurname, passangerDistrict, passangerCity, passangerAge;

//Console.Write("Yolcu Adı : ");
//passangerName=Console.ReadLine();

//Console.Write("Yolcu SoyAdı : ");
//passangerSurname = Console.ReadLine();

//Console.Write("İl Giriniz : ");
//passangerCity = Console.ReadLine();

//Console.Write("İlçe Giriniz : ");
//passangerDistrict = Console.ReadLine();

//Console.Write("Yaş Giriniz : ");
//passangerAge = Console.ReadLine();

//Console.WriteLine("TCKN : ");
//passangerId=Console.ReadLine();

//Console.WriteLine();
//Console.WriteLine("--------------------------");
//Console.WriteLine("Yolcu Ad Soyad: "+ passangerName+ " "+passangerSurname + "Yolcu TCKN : "+passangerId+"Yolcu Yaş : "+ passangerAge +"İl/ilçe: "+ passangerCity + "/"+passangerDistrict);

#endregion
#region Input & Int_Conversation 
//int shoesPrice, computerPrice, chairPrice, tvPrice;
//shoesPrice = 1000;
//computerPrice = 2000;
//chairPrice = 5000;
//tvPrice = 12000;

//int shoesCount, computerCount, chairCount, tvCount;
//Console.Write("Almak istediğiniz ayakkabı miktarını giriniz :");
//shoesCount = int.Parse(Console.ReadLine());
//Console.Write("Almak istediğiniz bilgisayar miktarını giriniz :");
//computerCount = Convert.ToInt32(Console.ReadLine());
//Console.Write("Almak istediğiniz sandalye miktarını giriniz :");
//chairCount= int.Parse(Console.ReadLine());
//Console.Write("Almak istediğiniz TV miktarını giriniz :");
//tvCount = int.Parse(Console.ReadLine());
//int totalPrice=(shoesCount*shoesPrice)+(computerCount*computerPrice)+(chairCount*chairPrice)+(tvCount*tvPrice);

//Console.WriteLine();

//Console.WriteLine("Toplam alışveriş tutarı  : "+totalPrice+" TL");
#endregion
#region Double Input & Conversation 
//double s1, s2, s3, ort;
//Console.Write("1. Sınav Notu : ");
//s1 = double.Parse(Console.ReadLine());
//Console.Write("2. Sınav Notu : ");
//s2 = double.Parse(Console.ReadLine());
//Console.Write("3. Sınav Notu : ");
//s3 = double.Parse(Console.ReadLine());

//ort = (s1 + s2 + s3) / 3;

//Console.WriteLine("3 Sınavın ortalaması : "+ ort );

#endregion
#region Char Input
//char gender;
//Console.WriteLine("Cinsiyet girin : ");
//gender=char.Parse(Console.ReadLine());
//Console.WriteLine("Seçilen cinsiyet : " + gender);
#endregion