using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Mapping
{
    public class PatientMap
    {
        public PatientMap(EntityTypeBuilder<Patient> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.FirstName).IsRequired();
            entityBuilder.Property(t => t.MidName);
            entityBuilder.Property(t => t.LastName).IsRequired();
            entityBuilder.Property(t => t.Suffix);
            entityBuilder.Property(t => t.AddressLine1).IsRequired();
            entityBuilder.Property(t => t.AddressLine2).IsRequired();
            entityBuilder.Property(t => t.Sex).IsRequired();
            entityBuilder.Property(t => t.DateOfBirth).IsRequired();
            entityBuilder.Property(t => t.EmiratesID).IsRequired();
            entityBuilder.Property(t => t.PassportNumber).IsRequired();
            entityBuilder.Property(t => t.WorkTitle);
            entityBuilder.Property(t => t.MailAddress);
            entityBuilder.Property(t => t.MobilePhone).IsRequired();
            entityBuilder.Property(t => t.HomePhone).IsRequired();
            entityBuilder.Property(t => t.WorkTitle);
            entityBuilder.Property(t => t.HasGaurdian);
            entityBuilder.Property(t => t.Nationality).IsRequired();
            entityBuilder.Property(t => t.InsuranceCoverage).IsRequired();
            entityBuilder.Property(t => t.MartialStatus);

            entityBuilder.HasOne(t => t.Guardian).WithOne(u => u.Patient).HasForeignKey<Guardian>(x => x.PatientID);
        }
    }

}
