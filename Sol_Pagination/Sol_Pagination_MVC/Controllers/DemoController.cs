using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sol_Pagination_MVC.Data;
using Sol_Pagination_MVC.Extensions;
using Sol_Pagination_MVC.Models;

namespace Sol_Pagination_MVC.Controllers
{
    public class DemoController : Controller
    {
        public async Task<IActionResult> Index(int page=1)
        {
            var dataPage = (await this.GetUsersDataAsync()).GetPaged(page, 2);

            return View(dataPage);
        }

        #region Private Method
        public async Task<IEnumerable<UserModel>> GetUsersDataAsync()
        {
            try
            {
                return await new UserData().GetUserDataAsync();
            }
            finally
            { }
        }
        #endregion
    }
}