﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookCar.Models
{
    public class BookingCars
    {
        public int id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Contact ")]
        public string Contact { get; set; }


        [Display(Name = "Car Model")]
        public string CarModel { get; set; }

        [Display(Name = "Booking Date")]
        public string BookingDate { get; set; }
    }
}
