using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace watchmy.money
{
    public interface ITransaction
    {
        string TId { get; set; }
        decimal Amount { get; set; }
        DateTime Posted { get; set; }
        string Description { get; set; }
    }
}
