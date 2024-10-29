
#region Parametre almayan geriye değer döndürmeyen Metod
//void List() 
//{
//    Console.WriteLine("Müşteri 1");
//    Console.WriteLine("Müşteri 2");
//    Console.WriteLine("Müşteri 3");
//    Console.WriteLine("Müşteri 4");
//}
//List();
#endregion

#region String Parametre alan geriye değer döndürmeyen Metodlar
//void WriteMethod(string customerName)
//{
//    Console.WriteLine(customerName);
//}
//WriteMethod("ali veli");
#endregion

#region Int tipinde parametre alan geriye değer döndürmeyen Metodlar
//void Sum(int n1, int n2, int n3)
//{
//    int result = n1 + n2 + n3;
//    Console.WriteLine(result);
//}
//Sum(3, 5, 8);


#endregion

#region Değer döndüren metodlar
//string CustomerName()
//{
//    return "Ali Veli";
//}

//CustomerName();
//string StudentCard()
//{
//    string name = "Ali", surname = "Veli";
//    return name + " " + surname;
//}
//Console.WriteLine(StudentCard());

#endregion

#region Geriye değer dönen string parametreli metodlar
//string CountryCard(string countryName, string capital, string flagColor)
//{
//    string cardInfo = countryName + " " + capital + " " + flagColor;
//    return cardInfo;
//}
//string v1, v2, v3;
//Console.WriteLine("Please write a country name : ");
//v1 = Console.ReadLine();
//Console.WriteLine("Please write a capital name : ");
//v2 = Console.ReadLine();
//Console.WriteLine("Please write flag color: ");
//v3 = Console.ReadLine();
//Console.WriteLine(CountryCard(v1, v2, v3)); 


#endregion

#region Geriye değer dönen int parametreli metodlar

//int Sum(int n1, int n2)
//{
//    int result = n1 + n2;
//    return result;  
//}
//Console.WriteLine(Sum(4,10));
//Console.WriteLine(Sum(5,10));
//Console.WriteLine(Sum(11,10));
//Console.WriteLine(Sum(14,10));
//Console.WriteLine(Sum(4,24));
#endregion

#region Örnek
string ExamResult(string name,int e1,int e2,int e3)
{
    int result = (e1+ e2+e3)/3;
    if (result >= 50)
    {
        return name + " named student passed "+ "Average : "+result;
    }
    else
    {
        return name + " named student failed " + "Average : " + result;
    }
        
}
Console.WriteLine(ExamResult("Ali",45,70,90));
Console.WriteLine(ExamResult("Veli",45,50,30));
#endregion


