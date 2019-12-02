using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProxyAndBD_Заместитель.Abstractions;
using ProxyAndBD_Заместитель.ContextBD;

namespace ProxyAndBD_Заместитель.Model
{
    class BookStore : IBook
    {
        PageContext db;

        public BookStore()
        {
            db = new PageContext();
        }

        public Page GetPage(int number)
        {
            return db.Pages.FirstOrDefault(p => p.Number == number);
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
