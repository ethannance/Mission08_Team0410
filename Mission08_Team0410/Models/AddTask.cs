using System.ComponentModel.DataAnnotations;

namespace Mission08_Team0410.Models
{
    public class AddTask
    {
        [Key]

        public int TaskId { get; set; }

        [Required(ErrorMessage = "Task Name is required")]

        public string TaskName { get; set; }

        public DateTime DueDate { get; set; }

        [Required(ErrorMessage = "Quadrant is required")]
        public int Quadrant { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public int CategoryId { get; set; }

        public bool? Completed { get; set; }
    }

}
    

    

