using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookCar.Data;
using BookCar.Models;

namespace BookCar.Pages.Booking
{
    public class IndexModel : PageModel
    {
        private readonly BookCar.Data.BookCarContext _context;

        public IndexModel(BookCar.Data.BookCarContext context)
        {
            _context = context;
        }

        public IList<BookingCars> BookingCars { get;set; }

        public async Task OnGetAsync()
        {
            BookingCars = await _context.BookingCars.ToListAsync();
        }
    }
}
