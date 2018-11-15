using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    [Table ("Client")]
    public class Client
    {
        [Key]
        [Required]
        public int ClientID { get; set; }
        [Required(ErrorMessage = "Enter your first name")]
        [DisplayName("First Name:")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Enter your last name")]
        [DisplayName("Last Name:")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Enter your address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Enter your city")]
        public string City { get; set; }
        [Required(ErrorMessage = "Enter your state")]
        public string State { get; set; }
        [Required(ErrorMessage = "Enter your zipcode")]
        [RegularExpression(@"^(?!00000)[0-9]{5,5}$", ErrorMessage = "Enter your 5-digit zipcode")]
        public string Zip { get; set; }
        [Required(ErrorMessage = "Enter your phone number")]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Enter your email address")]
        [EmailAddress(ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
    }
}