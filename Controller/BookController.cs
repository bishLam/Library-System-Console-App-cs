using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

//Business layer
namespace Controller
{
    public class BookController
    {
        public List<Book> BrowseBooks()
        {
            //call the relevant method inside the logic class
            BookLogic bookLogic = new BookLogic();
            List<Book> books = bookLogic.BrowseBooks();

            if(books == null)
            {
                return null;
            }

            else
            {
                return books;
            }
        }
    }
}
