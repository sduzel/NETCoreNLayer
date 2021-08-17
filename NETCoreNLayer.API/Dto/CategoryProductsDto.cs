using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCoreNLayer.API.Dto
{
    public class CategoryProductsDto :CategoryDto
    {
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
