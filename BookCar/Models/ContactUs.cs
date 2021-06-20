using System.ComponentModel.DataAnnotations;

namespace BookCar.Models
{
    public class ContactUs
    {

        public int id { get; set; }


        [Display(Name = "Name")]
        public string Name { get; set; }


        [Display(Name = "Email")]
        public string sEmail { get; set; }


        [Display(Name = "Contact ")]
        public string Contact { get; set; }


        [Display(Name = "Message")]
        public string Message { get; set; }

    }
}
