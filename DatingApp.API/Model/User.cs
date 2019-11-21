using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string userName { get; set; }
        public byte[] passswordHash { get; set; }
        public byte[] passwordSalt { get; set; }
    }
}