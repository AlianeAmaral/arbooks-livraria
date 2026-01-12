namespace Arbooks.Business.Models
{
    public class Book
    {
        public int id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public Specification specifications { get; set; }
    }
}