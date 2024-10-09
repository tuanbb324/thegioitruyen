using Microsoft.Data.SqlClient;
using System.Data;

namespace TheGioiTruyen.Repository
{
    public interface IProductService
    {

    }
    public class ProductService : IProductService
    {
        private readonly string _connectionString;

        public ProductService(string connectionString)
        {
            _connectionString = connectionString;
        }
        private IDbConnection Connection => new SqlConnection(_connectionString);
    }
}
