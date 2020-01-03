using System.ComponentModel.DataAnnotations;

namespace CrudBlazor.Data
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
    }
}
