using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch12_P2_LinqRetValues
{
    class ReturnQueryFromMethodClass
    {
        // QueryMethhod1 returns a query as its value.
        IEnumerable<string> QueryMethod1(ref int[] ints)
        {
            IEnumerable<string> intsToStrings = from i in ints
                                                where i > 4
                                                select i.ToString();
            return intsToStrings;
        }

        // QueryMethod2 returns a query as the value of parameter returnQ.
        void QueryMethod2(ref int[] ints, out IEnumerable<string> returnQ)
        {
            IEnumerable<string> intsToStrings = from i in ints
                                                where i < 4
                                                select i.ToString();
            returnQ = intsToStrings;
        }
    }
}
