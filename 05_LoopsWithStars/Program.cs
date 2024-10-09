
#region Alt alta 10 Yıldız
//for (int i = 0; i < 11; i++)
//{
//    Console.WriteLine("*");
//}
#endregion

#region Yan yana 10 Yıldız
//for (int i = 1; i < 11; i++)
//{

//    Console.Write("*");

//}

#endregion

//#region Alt alta 10 yıldız her satırda 10 yıldız

//for (int i = 1; i < 11; i++)
//{
//    Console.WriteLine("**********");
//}

//#endregion


#region Dik üçgen
//for (int i = 1; i < 11; i++)
//{
//    for (int j = 0; j < i; j++)
//    {
//        Console.Write("*");

//    }
//    Console.WriteLine();
//}

#endregion

#region Ters Dik Üçgen

//for (int i = 10; i > 0; i--)
//{
//    for (int j = 0; j < i; j++)
//    {
//        Console.Write("*");

//    }
//    Console.WriteLine();
//}

#endregion

#region Yatay Üçgen 
//for (int i = 1; i <= 10; i++)
//{
//    for (int j = 0; j < i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}

//for (int i = 9; i > 0; i--)
//{
//    for (int j = 0; j < i; j++)
//    {
//        Console.Write("*");

//    }
//    Console.WriteLine();
//}
#endregion

#region Yatık Üçgen 

//int n = 5;
//for (int i = 1; i <= n; i++)
//{
//    for (int j = n - 1; j > 0; j--)
//    {
//        Console.Write(" ");
//    }

//    for (int k = 1; k <= 2 * i - 1; k++)
//    {
//        Console.Write("*");
//    }

//    Console.WriteLine();
//}


//for (int i = n - 1; i >= 1; i--)
//{
//    for (int j = n - 1; j > 0; j--)
//    {
//        Console.Write(" ");
//    }

//    for (int k = 1; k <= 2 * i - 1; k++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}


#endregion

#region Piramit (Düz)
//int basamak = 5;
//for (int i = 1; i <= basamak; i++)
//{

//    for (int j = basamak - i; j > 0; j--)
//    {
//        Console.Write(" ");
//    }


//    for (int k = 1; k <= 2 * i - 1; k++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}
#endregion
#region Piramit (Ters)
//int basamak = 5;
//for (int i = basamak; i >= 1; i--)
//{

//    for (int j = basamak - i; j > 0; j--)
//    {
//        Console.Write(" ");
//    }

//    for (int k = 1; k <= 2 * i - 1; k++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}
#endregion

#region Eşkenar Dörtgen (Baklava Dilimi -Düz ve ters eşkenar üçgenin birleşimi-)
int basamak = 5;

// Üst üçgen
for (int i = 1; i <= basamak; i++)
{
    for (int j = basamak - i; j > 0; j--)
    {
        Console.Write(" ");
    }

    for (int k = 1; k <= 2 * i - 1; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

// Alt üçgen
for (int i = basamak; i >= 1; i--)
{
    for (int j = basamak - i; j > 0; j--)
    {
        Console.Write(" ");
    }

    for (int k = 1; k <= 2 * i - 1; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
#endregion