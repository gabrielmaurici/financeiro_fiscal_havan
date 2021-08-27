using Data.Models;
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
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Client> Clients  { get; set; }
        public DbSet<ContactModel> ContactModels  { get; set; }
        public DbSet<CurrentAccount> CurrentAccounts  { get; set; }
        public DbSet<Extract> Extracts  { get; set; }
        public DbSet<Installment> Installments  { get; set; }
        public DbSet<LojaModel> LojaModels  { get; set; }
        public DbSet<NoteIssue> NoteIssues  { get; set; }
        public DbSet<Tax> Taxes  { get; set; }
        public FiscalContext():base("Data Source=192.168.0.197;Initial Catalog=FinanceiroFiscal;Persist Security Info=True;User ID=fiscal;Password=1324@")
        {

        }
    }
}
