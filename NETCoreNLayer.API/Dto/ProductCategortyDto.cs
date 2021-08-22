using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCoreNLayer.API.Dto
{
    public class ProductCategortyDto : ProductDto
    {
        public CategoryDto Category { get; set; }
    }
}
