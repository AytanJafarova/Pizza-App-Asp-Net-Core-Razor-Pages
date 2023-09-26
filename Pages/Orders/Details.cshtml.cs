using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzaAppManagement.Data;
using PizzaAppManagement.Models;

namespace PizzaManagement_Razor_Asp_Net_Core.Pages.Orders
{
    public class DetailsModel : PageModel
    {
        private readonly PizzaAppManagement.Data.PizzaDbContext _context;

        public DetailsModel(PizzaAppManagement.Data.PizzaDbContext context)
        {
            _context = context;
        }

      public Order Order { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Orders == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.FirstOrDefaultAsync(m => m.Id == id);
            if (order == null)
            {
                return NotFound();
            }
            else 
            {
                Order = order;
            }
            return Page();
        }
    }
}
