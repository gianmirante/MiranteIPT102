using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiranteRestoOnlinePayment.Interface
{
    public class RestoOrder
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public decimal TotalAmount { get; set; }
       
        public string PaymentMethod { get; set; }
        public string TransactionStatus { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
