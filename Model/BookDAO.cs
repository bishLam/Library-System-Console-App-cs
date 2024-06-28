using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.BookDataSetTableAdapters;

namespace Model
{
    public class BookDAO
    {
        public List<Book> BrowseBooks()
        {

            //Load the Dataset and Execute the Relevant method 
            // inside this method, you will have sql 

            ViewBookTableAdapter viewBookTableAdapter = new ViewBookTableAdapter();
            BookDataSet.ViewBookDataTable viewBookDataTable= viewBookTableAdapter.BrowseBooks();

            int dataCount = viewBookDataTable.Count;
            if (dataCount == 0) {
                //there is no data in the table 
                return null;
            }
            else
            {
                //there is data
                List<Book> books = new List<Book>();

                foreach (DataRow row in viewBookDataTable.Rows)
                { 
                    Book book = new Book();
                    book.ISBN1 = row["ISBN"].ToString().Trim();
                    book.BookName = row["BookName"].ToString();
                    book.AuthorName = row["AuthorName"].ToString();
                    books.Add(book);

                }
                return books;
            }
        }
    }
}
