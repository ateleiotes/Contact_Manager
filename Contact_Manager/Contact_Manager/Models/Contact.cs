using System;
using System.ComponentModel.DataAnnotations;

namespace Contact_Manager.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        [Required(ErrorMessage = "Please enter a valid contact ID")]
        public string Firstname { get; set; }
        [Required(ErrorMessage = "Please enter a valid first name")]
        public string Lastname { get; set; }
        [Required(ErrorMessage = "Please enter a valid last name")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please enter a valid phone number")]
        public string Email { get; set; }

        public string Organization { get; set; }

        public DateTime DateAdded { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
        [Range(1, 4, ErrorMessage = "Please select a Category")]

        public string slug => Firstname?.Replace(" ", "-").ToLower()
            + "-" + Lastname?.Replace(" ", "-").ToLower();
    }
}
