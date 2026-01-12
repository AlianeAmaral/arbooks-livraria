using System.Text.Json;
using Arbooks.Business.DTOs;

namespace Arbooks.Business.Repository
{
    public class BookRepository
    {
        public BookRepository()
        {
        }

        public List<BookDTO> Load()
        {
            var jsonContent = File.ReadAllText("..\\Arbooks.Business\\books.json");
            var listBook = JsonSerializer.Deserialize<List<BookDTO>>(jsonContent);

            return listBook;
        }
    }
}