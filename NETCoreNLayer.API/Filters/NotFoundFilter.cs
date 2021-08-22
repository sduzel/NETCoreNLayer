using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NETCoreNLayer.API.Dto;
using NETCoreNLayer.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCoreNLayer.API.Filters
{
    public class NotFoundFilter : ActionFilterAttribute
    {
        private readonly IProductService _productService;
        public NotFoundFilter(IProductService productService)
        {
            _productService = productService;
        }
        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            int id = (int)context.ActionArguments.Values.FirstOrDefault();
            var product = await _productService.GetByIdAsync(id);
            if(product != null)
            {
                await next();
            }
            else
            {
                var errorDto = new ErrorDto();
                errorDto.Status = 404;
                errorDto.Errors.Add($"{id} numaralı ürün bulunamadı!");
                context.Result = new NotFoundObjectResult(errorDto);
            }
        }
    }
}
