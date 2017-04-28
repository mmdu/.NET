using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "please enter your email")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage = "please enter valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "please enter your phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "please specify whether you will attend")]
        public bool ? WillAttend { get; set; }
    }
}