using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities
{
    public class Schnapps
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public User CreatedBy { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Recipe Recipe { get; set; }
    }
}
