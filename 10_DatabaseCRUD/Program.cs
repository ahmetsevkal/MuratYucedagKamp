using System.Data;
using System.Data.SqlClient;
#region Category Ekleme (C)
//Console.WriteLine("*****Menü Sipariş Paneli*****");
//Console.WriteLine();
//Console.WriteLine("---------------------");
//Console.Write("Enter a category name  :");
//string newCategory = Console.ReadLine();

//SqlConnection sqlConnection = new("server=.;Initial Catalog=EgitimKampi;Integrated Security=true");
//sqlConnection.Open();
//SqlCommand cmd = new("insert into Category (CategoryName) values (@p1)", sqlConnection);
//cmd.Parameters.AddWithValue("@p1", newCategory);
//cmd.ExecuteNonQuery();
//sqlConnection.Close();
//Console.WriteLine("Category Added !");
//Console.ReadLine();
#endregion
#region Product Ekleme (C)
//decimal productPrice;
//Console.WriteLine("*****Menü Sipariş Paneli*****");
//Console.WriteLine();
//Console.WriteLine("---------------------");
//Console.Write("Enter a product name  :");
//string newProduct = Console.ReadLine();
//Console.Write("Enter product price  :");
//productPrice = Convert.ToDecimal(Console.ReadLine());
//SqlConnection sqlConnection = new("server=.;Initial Catalog=EgitimKampi;Integrated Security=true");
//sqlConnection.Open();
//SqlCommand cmd = new("insert into Product (ProductName,ProductPrice) values (@p1,@p2)", sqlConnection);
//cmd.Parameters.AddWithValue("@p1", newProduct);
//cmd.Parameters.AddWithValue("@p2", productPrice);
//cmd.ExecuteNonQuery();
//sqlConnection.Close();
//Console.WriteLine("Product Added !");
//Console.ReadLine();

#endregion
#region Product Listeleme (R)

//SqlConnection sqlConnection = new("Data Source=.;Initial Catalog= EgitimKampi;Integrated Security=True");
//sqlConnection.Open();
//SqlCommand command = new("select * from Product", sqlConnection);
//SqlDataAdapter adapter = new(command);
//DataTable dt = new();
//adapter.Fill(dt);
//foreach (DataRow dr in dt.Rows)
//{
//    foreach (var item in dr.ItemArray)
//    {
//        Console.WriteLine(item.ToString() + " ");
//    }
//    Console.WriteLine();
//}
//sqlConnection.Close();


//Console.ReadKey();
#endregion
#region Product Silme (D)

//Console.WriteLine("Silinecek olan ürnünün Id değerini girin : ");
//int productId=int.Parse(Console.ReadLine());

//SqlConnection sqlConnection = new("Data Source=.;Initial Catalog= EgitimKampi;Integrated Security=True");
//sqlConnection.Open();

//SqlCommand cmd = new("Delete from Product where ProductId=@pid",sqlConnection);
//cmd.Parameters.AddWithValue("@pid",productId);
//cmd.ExecuteNonQuery();  
//sqlConnection.Close();
//Console.WriteLine($"Id değerine sahip olan ürün silindi: {productId}");


//Console.ReadKey();
#endregion
#region Product Update(U)
Console.WriteLine("Güncellenecek olan ürnünün Id değerini girin : ");
int productId = int.Parse(Console.ReadLine());
Console.WriteLine("Güncellenecek olan ürnünün Name değerini girin : ");
string productName = Console.ReadLine();
Console.WriteLine("Güncellenecek olan ürnünün Price değerini girin : ");
decimal productPrice = decimal.Parse(Console.ReadLine());

SqlConnection sqlConnection = new("Data Source=.;Initial Catalog= EgitimKampi;Integrated Security=True");
sqlConnection.Open();
SqlCommand cmd = new("update Product set ProductName=@productName,ProductPrice=@productPrice where ProductId=@productId", sqlConnection);
cmd.Parameters.AddWithValue("@productName",productName);
cmd.Parameters.AddWithValue("@productPrice",productPrice);
cmd.Parameters.AddWithValue("@ProductId",productId);
cmd.ExecuteNonQuery();
sqlConnection.Close();
Console.WriteLine("Güncelleme tamamlandı.");

#endregion

