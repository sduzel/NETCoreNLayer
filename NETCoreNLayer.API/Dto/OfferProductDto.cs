using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCoreNLayer.API.Dto
{
    public class OfferProductDto : OfferDto
    {
        public ProductDto Product { get; set; }
    }
}
