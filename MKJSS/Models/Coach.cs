using System.ComponentModel.DataAnnotations;

namespace MKJSS.Models
{
    public class Coach
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get;}
    }
}
