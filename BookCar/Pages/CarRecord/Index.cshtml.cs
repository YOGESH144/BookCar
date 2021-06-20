using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookCar.Data;
using BookCar.Models;

namespace BookCar.Pages.CarRecord
{
    public class IndexModel : PageModel
    {
        private readonly BookCarContext _context;

        public IndexModel(BookCarContext context)
        {
            _context = context;
        }

        public IList<Car> Car { get;set; }

        public async Task OnGetAsync()
        {
            Car = await _context.Car.ToListAsync();
        }
    }
}
