using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    class FiscalContext : DbContext
    {
        public FiscalContext():base("Data Source=192.168.0.197;Initial Catalog=FinanceiroFiscal;Persist Security Info=True;User ID=fiscal;Password=1324@")
        {

        }
    }
}
