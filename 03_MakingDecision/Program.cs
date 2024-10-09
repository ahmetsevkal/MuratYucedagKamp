#region If - Else 

#region Example 1 - Password
//string password;
//Console.Write("Lütfen şifrenizi giriniz : ");
//password = Console.ReadLine();
//if (password == "asdf")
//{
//    Console.WriteLine("Şifre doğru");
//}
//else
//{
//    Console.WriteLine("Girilen şifre yanlış.");
//}
#endregion

#region Example 2 - Capital&Country
//string capital, country;
//Console.WriteLine("Başkent girin : ");
//capital = Console.ReadLine();

//Console.WriteLine("Ülke girin");
//country = Console.ReadLine();
//if (capital == "ankara"& country=="türkiye")
//{
//    Console.WriteLine("Veriler doğrulandı");
//}
//else
//{
//    Console.WriteLine("Hatalı giriş yapıldı.");
//}
#endregion

#region Exam Avarage Calculator
//int exam1, exam2, exam3 , avarage;
//string result="" ;
//Console.WriteLine(" Enter first exam result :");
//exam1 = int.Parse(Console.ReadLine());

//Console.WriteLine(" Enter second exam result :");
//exam2 = int.Parse(Console.ReadLine());

//Console.WriteLine(" Enter third exam result :");
//exam3= int.Parse(Console.ReadLine());

//avarage = (exam1 + exam2 + exam3)/3;
//Console.WriteLine("Avarage  :"+ avarage);

//if(avarage>0&avarage<50)
//{
//    result = "Fail!";
//}
//else if(avarage>50&avarage<70)
//{
//    result = "Not bad.";    
//}
//else if (avarage>70&avarage<84)
//{
//    result = "Good.";
//}
//else if (avarage>84)
//{
//    result = "Very good.";
//}

//Console.WriteLine(" "+ result);
#endregion

#region City Check
//string city;

//Console.WriteLine("Please enter a city name : ");

//city = Console.ReadLine();

//if(city=="ankara"|city=="adana"|city=="bursa"|city=="muğla")
//{
//    Console.WriteLine("City exists.");
//}
//else
//{
//    Console.WriteLine("Not exists.");
//}
#endregion

#region User/Admin Check
//Console.WriteLine("Enter username : ");
//string username = Console.ReadLine();
//if(username!="admin")
//{
//    Console.WriteLine("Not exists.");
//}
//else
//{
//    Console.WriteLine("Welcome");
//}


#endregion

#endregion

#region Mod  
#region Example 1
//int n1 = 30;
//int result = n1 % 5;
//Console.WriteLine(result);

#endregion
#region Example 2 
//int n1, n2, result;
//Console.WriteLine("First Number :");
//n1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Second Number :");
//n2 = int.Parse(Console.ReadLine());
//result = n1 % n2;

//Console.WriteLine("Mod : "+ result);

#endregion
#region Example 3
//Console.WriteLine("Sayı girin : ");
//int n1 = int.Parse (Console.ReadLine());
//if (n1%2==0)
//{
//    Console.WriteLine("Çift");
//}
//else
//{
//    Console.WriteLine("Tek");
//}
#endregion
#endregion

#region Decision with Char
#region Team Selector
//char team;

//Console.WriteLine("Lütfen bir harf girin : ");
//team=char.Parse(Console.ReadLine());

//if (team=='f'|team== 'F')
//{
//    Console.WriteLine("Fenerbahçe");
//}

//if (team == 'b' | team == 'B')
//{
//    Console.WriteLine("Beşiktaş");
//}

#endregion



#endregion

#region Food Menu
//Console.WriteLine("******Food Categories********");
//Console.WriteLine();
//Console.WriteLine("1-Soups");
//Console.WriteLine("2-Main Course");
//Console.WriteLine("3-Salads");
//Console.WriteLine("4-Sweets");
//Console.WriteLine("5-Bavareges");
//Console.WriteLine();
//Console.WriteLine("******Food Categories********");


//string menuChoose;
//Console.WriteLine("Choose menu number : ");
//menuChoose = Console.ReadLine();
//if (menuChoose == "1")
//{
//    Console.WriteLine("");
//    Console.WriteLine("1. Çorba ");
//    Console.WriteLine("2. Çorba ");
//    Console.WriteLine("3.Çorba");

//}
//else if (menuChoose == "2")
//{
//    Console.WriteLine("");
//    Console.WriteLine("1. Ana Yemek ");
//    Console.WriteLine("2. Ana Yemek ");
//    Console.WriteLine("3.Ana Yemek");
//}
//else if (menuChoose == "3")
//{
//    Console.WriteLine("");
//    Console.WriteLine("1. Salata ");
//    Console.WriteLine("2. Salata ");
//    Console.WriteLine("3.Salata");
//}
//else if (menuChoose == "4")
//{
//    Console.WriteLine("");
//    Console.WriteLine("1. Tatlı ");
//    Console.WriteLine("2. Tatlı ");
//    Console.WriteLine("3.Tatlı");

//}
//else if (menuChoose == "5")
//{
//    Console.WriteLine("");
//    Console.WriteLine("1. İçecek ");
//    Console.WriteLine("2. İçecek ");
//    Console.WriteLine("3.İçecek");
//}

#endregion

#region Switch - Case Örnek 1

//Console.WriteLine("Ay seçin : ");
//int secim = int.Parse(Console.ReadLine());

//switch (secim)
//{
//    case 1:
//        Console.WriteLine("Ocak");
//        break;
//    case 2:
//        Console.WriteLine("Şubat");
//        break;
//    case 3:
//        Console.WriteLine("Mart");
//        break;
//    case 4:
//        Console.WriteLine("Nisan");
//        break;
//    case 5:
//        Console.WriteLine("Mayıs");
//        break;
//    case 6:
//        Console.WriteLine("Haziran");
//        break;
//    case 7:
//        Console.WriteLine("Temmuz");
//        break;
//    case 8:
//        Console.WriteLine("Ağustos");
//        break;
//    case 9:
//        Console.WriteLine("Eylül");
//        break;
//    case 10:
//        Console.WriteLine("Ekim");
//        break;
//    case 11:
//        Console.WriteLine("Kasım");
//        break;
//    case 12:
//        Console.WriteLine("Aralık");
//        break;
//    default:
//        Console.WriteLine("Hatalı giriş");
//        break;

//}
#endregion

#region Switch - Case Örnek 2 Hesap Makinesi

int n1, n2, result;
char select;


Console.WriteLine("First number : ");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Second number : ");
n2 = int.Parse(Console.ReadLine());

Console.WriteLine("Choose action");
select = char.Parse(Console.ReadLine());

switch (select)
{
    case '+':
        result = n1 + n2;
        Console.WriteLine("Result : "+ result);
        break;
    case '-':
        result = n1 - n2;
        Console.WriteLine("Result : " + result);
        break;
    case '*':
        result = n1 * n2;
        Console.WriteLine("Result : " + result);
        break;
    case '/':
        result = n1 / n2;
        Console.WriteLine("Result : " + result);

        break;
    default:
        Console.WriteLine("Error!");
        break;
}
#endregion