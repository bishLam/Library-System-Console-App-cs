using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BookLogic
    {

        public List<Book> BrowseBooks()
        {
            //call the relevant method in the DAO(Data Access Object) class
               BookDAO bookDAO = new BookDAO();
            List<Book> books =  bookDAO.BrowseBooks();
            return books;
        }
    }
}
