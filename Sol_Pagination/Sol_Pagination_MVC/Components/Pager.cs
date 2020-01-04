using Microsoft.AspNetCore.Mvc;
using Sol_Pagination_MVC.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Pagination_MVC.Components
{
    public class Pager : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(PagedResultBase result)
        {
            return Task.FromResult((IViewComponentResult)View(result));
        }
    }
}
