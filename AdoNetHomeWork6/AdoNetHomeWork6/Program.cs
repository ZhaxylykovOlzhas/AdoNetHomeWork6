using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetHomeWork6
{
	class Program
	{
		static void Main(string[] args)
		{
			DataSet ShopDb = new DataSet("ShopDb");
			DataTable orders = new DataTable("Orders");
			DataTable customers = new DataTable("Customers");
			DataTable employees = new DataTable("Employees");
			DataTable products = new DataTable("Products");
			DataTable orderDetails = new DataTable("OrderDetails");



			DataColumn idColumn = new DataColumn("Id", Type.GetType("System.Int32"));
			idColumn.Unique = true; 
			idColumn.AllowDBNull = false; 
			idColumn.AutoIncrement = true;
			idColumn.AutoIncrementSeed = 1; 
			idColumn.AutoIncrementStep = 1; 

			DataColumn idCustomer = new DataColumn("idCustomer", Type.GetType("System.Int32"));
			idCustomer.Unique = false; 
			idCustomer.AllowDBNull = false; 
			idCustomer.AutoIncrement = false; 

			DataColumn idEmployess = new DataColumn("idCustomer", Type.GetType("System.Int32"));
			idEmployess.Unique = false; 
			idEmployess.AllowDBNull = false; 
			idEmployess.AutoIncrement = false; 


			orders.Columns.Add(idColumn);
			orders.Columns.Add(idCustomer);
			orders.Columns.Add(idEmployess);

			orders.PrimaryKey = new DataColumn[] { orders.Columns["Id"] };

            ShopDb.Tables.Add(orders);


			DataColumn id = new DataColumn("Id", Type.GetType("System.Int32"));
			id.Unique = true; 
			id.AllowDBNull = false; 
			id.AutoIncrement = true; 
			id.AutoIncrementSeed = 1; 
			id.AutoIncrementStep = 1;

			DataColumn nameColumn = new DataColumn("Name", Type.GetType("System.String"));

			DataColumn adressColumn = new DataColumn("Adress", Type.GetType("System.String"));

			customers.Columns.Add(id);
			customers.Columns.Add(nameColumn);
			customers.Columns.Add(adressColumn);

			customers.PrimaryKey = new DataColumn[] { customers.Columns["Id"] };

            ShopDb.Tables.Add(customers);

			DataColumn employeId = new DataColumn("Id", Type.GetType("System.Int32"));
			employeId.Unique = true;
			employeId.AllowDBNull = false;
			employeId.AutoIncrement = true;
			employeId.AutoIncrementSeed = 1;
			employeId.AutoIncrementStep = 1; 

			DataColumn nameEmployeColumn = new DataColumn("Name", Type.GetType("System.String"));

			employees.Columns.Add(employeId);
			employees.Columns.Add(nameEmployeColumn);

			employees.PrimaryKey = new DataColumn[] { employees.Columns["Id"] };

            ShopDb.Tables.Add(employees);

			DataColumn productsId = new DataColumn("Id", Type.GetType("System.Int32"));
			productsId.Unique = true;
			productsId.AllowDBNull = false;
			productsId.AutoIncrement = true;
			productsId.AutoIncrementSeed = 1;
			productsId.AutoIncrementStep = 1;

			DataColumn productName = new DataColumn("Name", Type.GetType("System.String"));

			DataColumn productCategory = new DataColumn("Category", Type.GetType("System.String"));


			products.Columns.Add(productsId);
			products.Columns.Add(productName);
			products.Columns.Add(productCategory);

			products.PrimaryKey = new DataColumn[] { employees.Columns["Id"] };

            ShopDb.Tables.Add(products);

			DataColumn orderDetailId = new DataColumn("Id", Type.GetType("System.Int32"));
			orderDetailId.Unique = true;
			orderDetailId.AllowDBNull = false;
			orderDetailId.AutoIncrement = true;
			orderDetailId.AutoIncrementSeed = 1;
			orderDetailId.AutoIncrementStep = 1;

			DataColumn orderId = new DataColumn("idOrder", Type.GetType("System.Int32"));
			orderId.Unique = false;
			orderId.AllowDBNull = false;
			orderId.AutoIncrement = false;

			DataColumn productId = new DataColumn("idProduct", Type.GetType("System.Int32"));
			orderId.Unique = false;
			orderId.AllowDBNull = false;
			orderId.AutoIncrement = false;

			DataColumn productPrice = new DataColumn("Price", Type.GetType("System.Decimal"));



			orderDetails.Columns.Add(orderDetailId);
			orderDetails.Columns.Add(orderId);
			orderDetails.Columns.Add(productId);
			orderDetails.Columns.Add(productPrice);


			orderDetails.PrimaryKey = new DataColumn[] { employees.Columns["Id"] };

            ShopDb.Tables.Add(orderDetails);

            ShopDb.Relations.Add("OrdersEmployers", employees.Columns["Id"], orders.Columns["idEmployess"]);
            ShopDb.Relations.Add("OrdersCustomers", orders.Columns["Id"], orders.Columns["idCustomer"]);
            ShopDb.Relations.Add("ProductsOrdersDetail", products.Columns["Id"], orderDetails.Columns["idProduct"]);
            ShopDb.Relations.Add("OrdersOrderDetails", orders.Columns["Id"], orderDetails.Columns["idOrder"]);
		}
	}
}
