using System.ComponentModel.DataAnnotations;

namespace ProcessRUs.Entities
{
    public class User
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
