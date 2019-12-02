using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProxyAndBD_Заместитель.Model;

namespace ProxyAndBD_Заместитель.ContextBD
{
    class PageContext : DbContext
    {
        public PageContext()
        : base("DBConnection")
        { }

        public DbSet<Page> Pages { get; set; }
    }
}
