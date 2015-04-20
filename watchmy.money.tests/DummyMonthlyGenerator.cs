using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace watchmy.money.tests
{
    public static class DummyMonthlyGenerator
    {
        public static IEnumerable<ITransaction> GenerateBaseYear()
        {
            var transactions = new List<ITransaction>();
            var randy = new Random();

                for (var days = 0; days < 365; days++)
                {
                    for (var num = 0; num < randy.Next(15); num++)
                    {
                        var d = new DateTime(2015,1,1);
                        d = d.AddDays(days).AddHours(randy.Next(0,24));
                        transactions.Add(new Transaction
                                             {
                                                 TId = Guid.NewGuid().ToString("D"),
                                                 Posted = d,
                                                 Amount = randy.RandyDecimal(),
                                                 Description = randy.RandyString(10)
                                             });
                    } 
                }

            return transactions;
        }

        public static IEnumerable<ITransaction> GenerateEasyMonthly()
        {
            var transactions = GenerateBaseYear().ToList();

            var randy = new Random();
            var d = new DateTime(2015,1,1);
            var amount = randy.RandyDecimal();

            for (var months = 0; months < 12; months++)
            {
                transactions.Add(new Transaction
                                     {
                                        TId = Guid.NewGuid().ToString("D"),
                                        Description = "HerpDerpConsolidated",
                                        Amount = amount,
                                        Posted = d.AddMonths(months).AddHours(randy.Next(0,24))
                                     });
            }

            return transactions.OrderBy(x => x.Posted);
        } 
    }
}
