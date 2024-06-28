using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Book
    {
        private string ISBN;
        private string bookName;
        private string authorName;

        public string ISBN1 { get => ISBN; set => ISBN = value; }
        public string BookName { get => bookName; set => bookName = value; }
        public string AuthorName { get => authorName; set => authorName = value; }
    }
}
