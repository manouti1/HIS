using Domain.Validation;
using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Patient : BaseObject
    {
        [Required(ErrorMessage = "First name required", AllowEmptyStrings = false)]
        public string FirstName { get; set; }
        public string MidName { get; set; }
        [Required(ErrorMessage = "Last name required", AllowEmptyStrings = false)]
        public string LastName { get; set; }
        public string Suffix { get; set; }
        [Required(ErrorMessage = "Address Line1 required", AllowEmptyStrings = false)]
        public string AddressLine1 { get; set; }
        [Required(ErrorMessage = "Address Line2 required", AllowEmptyStrings = false)]
        public string AddressLine2 { get; set; }
        public string POBox { get; set; }
        [Required(ErrorMessage = "Sex required", AllowEmptyStrings = false)]
        public string Sex { get; set; }
        [Required(ErrorMessage = "Date Of Birth required", AllowEmptyStrings = false)]
        [CustomValidation(typeof(AgeValidation), "IsAgeValid")]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "Passport Number required", AllowEmptyStrings = false)]
        public string PassportNumber { get; set; }
        [Required(ErrorMessage = "Emirates ID required", AllowEmptyStrings = false)]
        public string EmiratesID { get; set; }
        public string WorkTitle { get; set; }
        public string MailAddress { get; set; }
        [Required(ErrorMessage = "Mobile required", AllowEmptyStrings = false)]
        public string MobilePhone { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        [CustomValidation(typeof(GaudrianValidation), "IsGuardianValid")]
        public bool HasGaurdian { get; set; }
        [Required(ErrorMessage = "Nationality required", AllowEmptyStrings = false)]
        public string Nationality { get; set; }
        [Required(ErrorMessage = "Insurance Coverage required", AllowEmptyStrings = false)]
        public string InsuranceCoverage { get; set; }
        public string MartialStatus { get; set; }

        public virtual Guardian Guardian { get; set; }

    }
}
