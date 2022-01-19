using System.ComponentModel.DataAnnotations;

namespace HelloWorld
{
    public class NameDto
    {
        [Required, StringLength(255, MinimumLength = 1)]
        public string Name { get; set; }        
    }
}
