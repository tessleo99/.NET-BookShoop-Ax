using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShoop.Data
{
    
    public class Books
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Language { get; set; }
        public int TotalPages { get; set; }


    }


}
