using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using UdemyNLayer.Core.Service;
using UdemyNLayer.DTOS;

namespace UdemyNLayer.Filters
{
    public class NotFoundFilter:ActionFilterAttribute
    {
        public IProductService _productService;
        public NotFoundFilter(IProductService productService)
        {
            _productService = productService;
        }

        public async override  Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            int id = (int) context.ActionArguments.Values.FirstOrDefault();

            var product = await _productService.GetByIdAsync(id);


            if (product!= null)
            {
                await  next();
            }
            else
            {
                ErrorDto errorDto = new ErrorDto();
                errorDto.Status = 404;

                errorDto.Errors.Add($"Product with the id of {id} is not found");

                context.Result = new NotFoundObjectResult(errorDto); 
            }
        }
    }
}
