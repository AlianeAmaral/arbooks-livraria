using Arbooks.Business.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Arbooks.API.Controllers
{
    [ApiController]
    [Route("book")]
    public class BookController : ControllerBase
    {
        public BookController() { }

        [HttpGet("search")]
        public IActionResult Search(string? term, string? order)
        {
            var bookList = new BookRepository().Load();

            // exibição e busca do json, lambda / coleções para evitar carregamentos desnecessários
            if (!string.IsNullOrWhiteSpace(term))
            {
                bookList = bookList
                .Where(book =>
                    book.name.Contains(term, StringComparison.OrdinalIgnoreCase)
                    || (book.specifications != null &&
                        (book.specifications.author.Contains(term, StringComparison.OrdinalIgnoreCase)
                          || book.specifications.illustrator.ToString().Contains(term, StringComparison.OrdinalIgnoreCase)
                          || book.specifications.genres.ToString().Contains(term, StringComparison.OrdinalIgnoreCase)
                        )
                    )
                )
                .ToList();
            }
                bookList = order switch
                {
                    "priceAsc" => bookList.OrderBy(book => book.price).ToList(),
                    "priceDesc" => bookList.OrderByDescending(book => book.price).ToList(),
                    _ => bookList
                };
                return Ok(bookList);
        }
    }
}
