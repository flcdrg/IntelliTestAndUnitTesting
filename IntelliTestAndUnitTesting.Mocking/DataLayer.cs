using System.Configuration;
using System.Data.SqlClient;

namespace IntelliTestAndUnitTesting.Mocking
{
    public class DataLayer : IDataLayer
    {
        public Order GetOrder(int orderId)
        {
            using (
                var conn =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["WideWorldImporters"].ConnectionString))
            {
                conn.Open();

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        "SELECT TOP (1) OrderDate, ExpectedDeliveryDate, IsUndersupplyBackordered FROM [Sales].[Orders] WHERE OrderID = @OrderId";
                    cmd.Parameters.AddWithValue("OrderId", orderId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var order = new Order();
                            order.Id = orderId;
                            order.OrderDate = reader.GetDateTime(0);
                            order.ExpectedDeliveryDate = reader.GetDateTime(1);
                            order.IsUndersupplyBackordered = reader.GetBoolean(2);

                            return order;
                        }

                        return null;
                    }
                }
            }
        }
    }
}