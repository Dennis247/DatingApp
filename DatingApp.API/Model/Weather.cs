using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Model
{
    public class Weather
    {
        [Key]
        public int Id { get; set; }
        public string temperature { get; set; }
    }
}