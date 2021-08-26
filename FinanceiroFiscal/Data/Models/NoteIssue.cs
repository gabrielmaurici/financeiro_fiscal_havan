using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class NoteIssue : BaseModel
    {
        public decimal Valor { get; set; }
        public int BarCode { get; set; }
        //public Store Store { get; set; }
        //public Client Client { get; set; }
        //public Product Product { get; set; }
        //public Tax Tax { get; set; }
    }
}