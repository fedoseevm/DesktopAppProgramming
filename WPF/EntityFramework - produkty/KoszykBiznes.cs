using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework___produkty
{
    internal class KoszykBiznes
    {
        public KoszykContext KoszykContext { get; set; }

        public KoszykBiznes()
        {
            KoszykContext = new KoszykContext();
        }
    }
}
