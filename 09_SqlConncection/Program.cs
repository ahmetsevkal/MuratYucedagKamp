using System.Data;
using System.Data.SqlClient;

Console.WriteLine("***** C# Veritabanlı Kategori Listeleme*****");
Console.WriteLine();

Console.WriteLine("---------------------------");
Console.WriteLine();

Console.WriteLine("--------------------");
Console.WriteLine("1-Categories");
Console.WriteLine("2-Products");
Console.WriteLine("3-Orders");
Console.WriteLine("4-Logout");
Console.Write("Enter table number : ");
string tablenumber = Console.ReadLine();
Console.WriteLine("--------------------");
SqlConnection sqlConnection = new ("Data Source=.;Initial Catalog= EgitimKampi;Integrated Security=True");
sqlConnection.Open();
SqlCommand command = new ("select * from Category",sqlConnection);
SqlDataAdapter adapter = new (command);
DataTable dt = new();
adapter.Fill(dt);
foreach (DataRow dr in dt.Rows)
{
	foreach (var item in dr.ItemArray)
	{
        Console.WriteLine(item.ToString());
	}
  
}  Console.WriteLine();
sqlConnection.Close();


Console.Read();