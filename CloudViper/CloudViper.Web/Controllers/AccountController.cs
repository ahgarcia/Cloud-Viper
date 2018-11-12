using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudViper.Infrastructure.Data;
using CloudViper.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace CloudViper.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly ViperDbContext _dbContext;

        public AccountController(ViperDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SignIn(AccountViewModel model)
        {
            return View(model);
        }
    }
}