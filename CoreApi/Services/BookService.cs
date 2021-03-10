using CoreApi.Models;
using System;
using System.Collections.Generic;

namespace CoreApi.Services
{
    public class BookService : IBookService
    {
        private List<Book> books = new List<Book>()
        {
            new Book
            {
                Id=1,
                Name="Rs Agarwal",
                RetailPrice = 56
            },
            new Book
            {
                Id=4,
                Name="Papa rancho",
                RetailPrice = 44
            }
        };
        public Book GetById(int id)
        {
            var book = books.Find(x => x.Id == id);
            if(book == null)
                throw new NotImplementedException();
            return book;
        }
    }
}
