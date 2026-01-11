using Dapper;
using Microsoft.Data.SqlClient; 
using MiranteRestoOnlinePayment.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiranteRestoOnlinePayment
{
    public class RestoPaymentRepository
    {
        
        private readonly string _connectionString = "Server=RestoServer;Database=RestoDB;Integrated Security=true;Encrypt=True;";

       
        public async Task<int> ExecutePaymentAsync(RestoOrder order)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                
                string sql = @"INSERT INTO RestoOrders (CustomerName, TotalAmount, PaymentMethod, TransactionStatus, CreatedAt) 
                           VALUES (@CustomerName, @TotalAmount, @PaymentMethod, 'Completed', GETDATE());
                           SELECT CAST(SCOPE_IDENTITY() as int);";

                return await db.ExecuteScalarAsync<int>(sql, order);
            }
        }

       
        public async Task<IEnumerable<RestoOrder>> GetCustomerTransactions(string name)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return await db.QueryAsync<RestoOrder>(
                    "SELECT * FROM RestoOrders WHERE CustomerName = @CustomerName",
                    new { CustomerName = name }
                );
            }
        }
    }
}
