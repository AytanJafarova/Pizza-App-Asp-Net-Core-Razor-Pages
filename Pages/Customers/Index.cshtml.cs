using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzaAppManagement.Data;
using PizzaAppManagement.Models;

namespace PizzaManagement_Razor_Asp_Net_Core.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly PizzaAppManagement.Data.PizzaDbContext _context;

        public IndexModel(PizzaAppManagement.Data.PizzaDbContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Customers != null)
            {
                Customer = await _context.Customers.AsNoTracking().ToListAsync(); /////   look at this!!!!
            }
        }
    }
}
