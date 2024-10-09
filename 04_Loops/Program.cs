
#region For Loops
//for (int i = 1; i <5; i++)
//{
//    Console.WriteLine("C# Kampı");
//}

//for (int i = 1; i < 20; i++)
//{
//    Console.WriteLine(i);
//}

//for (int i= 3; i<=50 ; i+=3)
//{
//    Console.WriteLine(i);
//}


//Console.WriteLine("Ekrana yazılmasını isteğiniz miktarı girin : ");
//int count = int.Parse(Console.ReadLine());
//for (int i = 0; i < count; i++)
//{
//    Console.WriteLine($"{i} . YAŞASIN CUMHURİYET !!"); 
//}
#endregion

#region Making Decision with For Loops


//for (int i = 5; i <= 100; i++)
//{
//	if (i%5==0)
//	{
//        Console.WriteLine(i);
//	}
////}
//int total = 0;
//for (int i = 1; i <= 10; i++)
//{
//    total += i;
//}

//Console.WriteLine(total);

//int total = 0;
//for (int i = 1; i < 20; i++)
//{
//    if (i % 2 == 0)
//    {
//        total += i;
//        Console.WriteLine(i);
//    }
//}
//Console.WriteLine("--------");
//Console.WriteLine(total);


//int counter = 0;
//for (int i = 0;i<50;i++)
//{
//    if (i % 7 == 0)
//    {
//        counter += 1;
//        Console.WriteLine(i);
//    }
//}


//int bakteri = 1;
//for (int i = 1; i <= 24; i++)
//{
//    bakteri *= 2;
//        Console.WriteLine(i + ".Saat sonunda: " + bakteri);
//}



#endregion

#region While Loop

//int i = 1;
//while (i<=10)
//{
//    Console.WriteLine("while döngüsü");
//    i++;
//}

//int i = 1;
//while (i<=10)
//{
//	if (i%3==0)
//	{
//        Console.WriteLine(i);
//	}
//	i++;
//}


//int i = 1;
//int total = 0;

//while (i<=10)
//{
//    total += i;
//    i++;
//}
//Console.WriteLine(total);

Console.WriteLine("Enter a number : ");
int number, ones, tens, hundereds, total;
number=Convert.ToInt32(Console.ReadLine());
ones = number%10;
tens = (number%100)/10;
hundereds = number/100;

Console.WriteLine(hundereds+"---"+tens+"---"+ones+"---");
total=ones+tens+hundereds;
Console.WriteLine(total);
#endregion