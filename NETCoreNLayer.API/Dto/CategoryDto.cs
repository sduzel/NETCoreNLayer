using System.ComponentModel.DataAnnotations;

namespace NETCoreNLayer.API.Dto
{
    public class CategoryDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Kategory adı giriniz!")]
        public string Name { get; set; }
    }
}
