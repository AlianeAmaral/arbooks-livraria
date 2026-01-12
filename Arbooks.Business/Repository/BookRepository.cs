using System.Text.Json;
using Arbooks.Business.Models;

namespace Arbooks.Business.Repository
{
    public class BookRepository
    {
        public BookRepository()
        {
        }

        public List<Book> Load()
        {
            var jsonContent = File.ReadAllText("..\\Arbooks.Business\\books.json");
            var listBook = JsonSerializer.Deserialize<List<Book>>(jsonContent);

            return listBook;
        }
    }
}