using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Client : BaseModel
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public CurrentAccount CurrentAccount { get; set; }
    }
}
