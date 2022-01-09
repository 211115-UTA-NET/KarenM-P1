
namespace P1CoffeeShopApp.UI
{
    public class Program
    {
        //public static readonly HttpClient httpClient = new ();
        //string connectionString = File.ReadAllText("C:/Users/mkare_wyte20y/Revature/DQL_Database.txt");
        //need to add exception for connection issue
        //IRepository repository = new SqlRepository(connectionString); //need to fix

        public static /*async*/ void Main(string[] args)
        {
            //Uri server = new("localhost");
            Uri server = new("zureurlwemade");

            //HttpResponseMessage respone = await HttpClient.GetAsync($"https://localhost:7276/api/");

            //IRepository repository = new SqlRepository(connectionString);//need to fix
            ////Reading to database using DataReader
            //static void HasRows(SqlConnection connection)
            //{
            //    using (connection)
            //    {
            //        SqlCommand command = new SqlCommand(
            //          "SELECT Store, CategoryName FROM Categories;",
            //         connection);
            //        connection.Open();

            //        SqlDataReader reader = command.ExecuteReader();

            //        if (reader.HasRows)
            //        {
            //            while (reader.Read())
            //            {
            //                Console.WriteLine("{0}\t{1}", reader.GetInt32(0),
            //                    reader.GetString(1));
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("If you reading this its connected.");
            //        }
            //        reader.Close();
            //    }
            //}
            Console.WriteLine("Hello, CoffeeShop!");



            ////Version 3
            //Customers newCustomers = new Customers();
            //newCustomers.customers();


            //version 4 12/21
            Order newOrder = new Order();
            newOrder.Ordering();

            //Locations newLocations = new Locations();
            //newLocations.locationId();
            Console.ReadKey();//
        }


    }


}