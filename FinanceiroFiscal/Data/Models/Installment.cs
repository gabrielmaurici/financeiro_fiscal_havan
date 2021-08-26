using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Installment : BaseModel
    {
        public int ParcelQuantity { get; set; }
        public float TaxFees { get; set; }
    }
}
