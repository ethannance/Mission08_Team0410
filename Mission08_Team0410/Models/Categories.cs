using System.ComponentModel.DataAnnotations;

namespace Mission08_Team0411.Models
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName {  get; set; }
    }
}
