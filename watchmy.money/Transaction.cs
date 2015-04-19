using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace watchmy.money
{
    public class Transaction : ITransaction
    {
        public string TId { get; set; }
        public decimal Amount { get; set; }
    }
}
