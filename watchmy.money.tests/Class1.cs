using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace watchmy.money.tests
{
    using System.Runtime.InteropServices;

    using NUnit.Framework;

    [TestFixture]
    public class Class1
    {
        [Test]
        public void derp()
        {
            var rand = new Random();
            var list = DummyMonthlyGenerator.GenerateEasyMonthly();


            list.ForEach(x=>Console.WriteLine(string.Format("Date:{0} Desc:{1} Amount:{2}",x.Posted.ToShortDateString(),x.Description,x.Amount)));


        }
    }
}
