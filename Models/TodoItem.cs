using System.ComponentModel.DataAnnotations;

namespace ServerlessTodoApi.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public bool IsComplete { get; set; }
    }
}