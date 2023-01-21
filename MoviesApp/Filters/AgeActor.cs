using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MoviesApp.Filters
{
    public class AgeActor: Attribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var formDate = DateTime.Parse(context.HttpContext.Request.Form["DateOfBirth"]);
            if ( DateTime.Now.Year - formDate.Year>99 || DateTime.Now.Year - formDate.Year<7)
            {
                context.Result = new BadRequestResult();
            }
        }
        
        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }
    }
}