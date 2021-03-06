//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CV.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Interests
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter interest description!")]
        [StringLength(500, ErrorMessage = "Please only enter 4-500 length character.", MinimumLength = 4)]
        public string DESCRIPTION { get; set; }
        [Required(ErrorMessage = "Please enter interest name!")]
        [StringLength(20, ErrorMessage = "Please only enter 4-20 length character.", MinimumLength = 4)]
        public string HEADER { get; set; }
    }
}
