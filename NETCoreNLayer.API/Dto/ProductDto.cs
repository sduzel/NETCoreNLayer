using System.ComponentModel.DataAnnotations;

namespace NETCoreNLayer.API.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
    }
}
