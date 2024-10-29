
#region Foreach
//int[] numbers = { 34, 35, 16, 48, 50, 55, 70, 78, 90, 3 };
//foreach (var number in numbers)
//{
//    if (number % 2 == 0)
//    {
//        Console.WriteLine(number);
//    }
//    else { Console.WriteLine("sayi ikiye tam bölünmedi"); }
//}


#endregion

#region Foreach Sayı Toplama
//int[] numbers = { 34, 35, 16, 48, 50, 55, 70, 78, 90, 3 };
//int total = 0;
//foreach (var item in numbers)
//{
//    total += item;

//}
//Console.WriteLine(total);
#endregion

#region Foreach-List kullanımı
//List<int> numbers = new List<int> ()
//{
//    1,2,3,4,5,6,7,8,9
//};
//foreach (var number in numbers)
//{
//    Console.WriteLine(number);
//}
#endregion

#region Foreach Char kullanımı
//string word = "Ahmet";
//foreach (char c in word)
//{
//    Console.WriteLine(c);
//}
#endregion

#region Örnek Sınav Sistemi
Console.WriteLine("***** C# Eğitim Kampı*****");
Console.WriteLine();

Console.WriteLine("---------------");
Console.WriteLine("Sınıf mevcudunuzu girin : ");
int studentCount = int.Parse(Console.ReadLine());

string[]studentNames=new string[studentCount];
double[] studentAvg = new double[studentCount];
for (int i = 0; i < studentCount; i++)
{
    Console.Write($"{i+1}.öğrencinin ismini girin : ");
    studentNames[i]=Console.ReadLine();
    double totalExamResult = 0;
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"{studentNames[i]} adlı öğrencinin {j+1}. sınav notunu girin : ");
        double value=double.Parse(Console.ReadLine());
        totalExamResult += value;
    }
    studentAvg[i] = totalExamResult/3;
}
for (int i = 0;i< studentCount;i++)
{
    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması {studentAvg[i]}");
    if (studentAvg[i] > 49)
    { Console.WriteLine("Başarılı"); }
    else
    {
        Console.WriteLine("Tekrar deneyin..!");
    }
}
#endregion
