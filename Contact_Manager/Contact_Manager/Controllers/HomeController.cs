using Contact_Manager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contact_Manager.Controllers
{
    public class HomeController : Controller
    {
        // Context variable
        private ContactContext context { get; set; }

        public HomeController(ContactContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            // Returns list of contacts ordered by first name
            var contacts = context.Contacts
                .Include(c => c.Category)
                .OrderBy(context => context.Firstname).ToList();
            return View(contacts);
        }
    }
}
