﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzaAppManagement.Data;
using PizzaAppManagement.Models;

namespace PizzaManagement_Razor_Asp_Net_Core.Pages.OrderDetails
{
    public class IndexModel : PageModel
    {
        private readonly PizzaAppManagement.Data.PizzaDbContext _context;

        public IndexModel(PizzaAppManagement.Data.PizzaDbContext context)
        {
            _context = context;
        }

        public IList<OrderDetail> OrderDetail { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.OrderDetails != null)
            {
                OrderDetail = await _context.OrderDetails
                .Include(o => o.Order)
                .Include(o => o.Product).ToListAsync();
            }
        }
    }
}
