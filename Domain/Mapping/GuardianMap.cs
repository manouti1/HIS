using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Mapping
{
    public class GuardianMap
    {
        public GuardianMap(EntityTypeBuilder<Guardian> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Address).IsRequired();
            entityBuilder.Property(t => t.Phone).IsRequired();
            entityBuilder.Property(t => t.Relation);

        }

    }
}
