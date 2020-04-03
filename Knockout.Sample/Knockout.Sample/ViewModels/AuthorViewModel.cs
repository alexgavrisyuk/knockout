using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Knockout.Sample.ViewModels
{
    public class AuthorViewModel
    {
        [JsonProperty(PropertyName="id")]
        public int Id { get; set; }
        
        [Required]
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }
        
        [Required]
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }
        
        [JsonProperty(PropertyName = "biography")]
        public string Biography { get; set; }
    }

}