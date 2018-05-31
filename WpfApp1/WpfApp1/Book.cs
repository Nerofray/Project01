using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WpfApp1
{
    public class Book
    {
        public String name { get; set; }
        public String author { get; set; }
        public String content { get; set; }
        public String imBook { get; set; }

        public Book(String Name, String Author, String Content, String ImBook)
        {
            name = Name;
            author = Author;
            content = Content;
            imBook = ImBook;
        }
    }
}
