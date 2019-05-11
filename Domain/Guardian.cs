using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    public class Guardian : BaseObject
    {
        [Required(ErrorMessage = "Phone required", AllowEmptyStrings = false)]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Address required", AllowEmptyStrings = false)]
        public string Address { get; set; }
        [Required(ErrorMessage = "Relation required", AllowEmptyStrings = false)]
        public string Relation { get; set; }
        public Patient Patient { get; set; }
        [ForeignKey("Patient")]
        public int PatientID { get; set; }
    }
}
