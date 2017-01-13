using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using cursoVidly.Models;

namespace cursoVidly.ViewModels
{
    public class CustomerFormViewModel
    {

        public IEnumerable<MembershipType> MembershipTypes { get; set; }

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        public bool IsSuscribibedToNewsLetter { get; set; }

        [Display(Name = "Membership Type")]
        [Required]
        public byte? MembershipTypeId { get; set; }

        [Display(Name = "Date of birth")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

        public string Title
        {
            get
            {


                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }

        public CustomerFormViewModel()
        {
            Id = 0;
        }

        public CustomerFormViewModel(Customers customer)
        {
            Id = customer.Id;
            Name = customer.Name;
            IsSuscribibedToNewsLetter = customer.IsSuscribibedToNewsLetter;
            MembershipTypeId = customer.MembershipTypeId;
            Birthdate = customer.Birthdate;
        }

    }
}