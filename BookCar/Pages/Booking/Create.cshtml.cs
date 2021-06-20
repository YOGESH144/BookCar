using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BookCar.Data;
using BookCar.Models;

namespace BookCar.Pages.Booking
{
    public class CreateModel : PageModel
    {
        private readonly BookCar.Data.BookCarContext _context;

        public CreateModel(BookCar.Data.BookCarContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BookingCars BookingCars { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.BookingCars.Add(BookingCars);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
