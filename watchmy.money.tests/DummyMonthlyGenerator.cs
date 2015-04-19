using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace watchmy.money.tests
{
    public static class DummyMonthlyGenerator
    {
        public static IEnumerable<ITransaction> GenerateEasy()
        {
            var transactions = new List<ITransaction>();

            for (var months = 0; months < 12; months++)
            {
                for (var days = 0; days < 365; days++)
                {
                    
                }
            }

        }
    }
}
