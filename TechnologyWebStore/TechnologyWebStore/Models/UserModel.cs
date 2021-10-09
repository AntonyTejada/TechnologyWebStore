using System.ComponentModel.DataAnnotations;

namespace TechnologyWebStore.Models
{
    public class UserModel
    {
        [Key]
        public int IdUser { get; set; }
        [MaxLength (50)]
        public string NameUser { get; set; }
        [MaxLength(50)]
        public string LastNameUser { get; set; }
        public string EmailUser { get; set; }

    }
}
