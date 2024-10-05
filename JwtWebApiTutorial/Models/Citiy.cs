using System.ComponentModel.DataAnnotations;

namespace JwtWebApiTutorial.Models
{
    public class Citiy
    {
        [Key]
        public Guid CityId { get; set; }
        public string CityName { get; set; } = string.Empty;
    }
}
