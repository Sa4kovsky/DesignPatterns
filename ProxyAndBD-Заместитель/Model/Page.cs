using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyAndBD_Заместитель.Model
{
    /* Класс Page представляет отдельную страницу книги, у которой есть номер и текст. */
    class Page
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Text { get; set; }
    }
}
