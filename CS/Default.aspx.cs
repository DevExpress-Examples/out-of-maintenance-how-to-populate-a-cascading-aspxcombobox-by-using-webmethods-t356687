using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Services;
using System.Web.UI.WebControls;

public class Product {
	public string Name { get; set; }
	public string ID { get; set; }
	public Product(string name, string id) {
		Name = name;
		ID = id;
	}
}
public partial class _Default : System.Web.UI.Page {
	static string connectionString = ConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString.ToString();

	[WebMethod]
	public static List<Product> GetData(string categoryID) {
		DataTable dt = new DataTable();
		using(SqlConnection con = new SqlConnection(connectionString)) {
			string query = "SELECT ProductName, ProductID FROM Products WHERE CategoryID=" + categoryID;
			SqlCommand cmd = new SqlCommand(query, con);
			SqlDataAdapter da = new SqlDataAdapter(cmd);			
			da.Fill(dt);
		}

		List<Product> listOfProducts = dt.AsEnumerable()
			.Select(a => new Product(a["ProductName"].ToString(), a["ProductID"].ToString()))
			.ToList();
				
		return listOfProducts;
	}
}