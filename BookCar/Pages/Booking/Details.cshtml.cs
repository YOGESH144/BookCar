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
    public class DetailsModel : PageModel
    {
        private readonly BookCar.Data.BookCarContext _context;

        public DetailsModel(BookCar.Data.BookCarContext context)
        {
            _context = context;
        }

        public BookingCars BookingCars { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BookingCars = await _context.BookingCars.FirstOrDefaultAsync(m => m.id == id);

            if (BookingCars == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
