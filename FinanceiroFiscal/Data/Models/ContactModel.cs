using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ContactModel:BaseModel
    {
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
