//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Application.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class user
    {
        public int userId { get; set; }

        [Required(ErrorMessage ="Type User Name")]
        [DisplayName("User Name")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Type Email")]
        [DisplayName("Email")]
        public string email { get; set; }

        [Required(ErrorMessage = "Type Password")]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string password { get; set; }

        [Compare("password")]
        [DataType(DataType.Password)]
        [DisplayName("Confirm Password")]
        public string confirmpassword { get; set; }
    }
}
