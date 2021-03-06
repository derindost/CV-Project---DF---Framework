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

    public partial class Languages
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter language!")]
        [StringLength(20, ErrorMessage = "Please only enter 4-20 length character.", MinimumLength = 4)]
        public string LANGUAGE { get; set; }
        [Required(ErrorMessage = "Please enter interest name!")]
        [StringLength(3, ErrorMessage = "Please enter numbers from 1-100 only.", MinimumLength = 1)]
        public Nullable<int> SUCCSESS { get; set; }
    }
}
