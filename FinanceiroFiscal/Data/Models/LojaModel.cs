using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class LojaModel:BaseModel
    {
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string IE { get; set; }
        public Address Addres { get; set; }
        public ContactModel Contact { get; set; }
    }
}
