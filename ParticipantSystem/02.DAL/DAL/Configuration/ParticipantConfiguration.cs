using Entities.TableModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configuration
{
    public class ParticipantConfiguration: IEntityTypeConfiguration<Participant>
    {
        public void Configure(EntityTypeBuilder<Participant> builder)
        {
            builder.Property(x => x.Id).HasColumnType("int").UseIdentityColumn(1, 1);
            builder.Property(x => x.Name).HasColumnType("nvarchar").HasMaxLength(250);
            builder.Property(x => x.Age).HasColumnType("int");
            builder.Property(x => x.Country).HasColumnType("nvarchar").HasMaxLength(250);
            builder.Property(x => x.TeamName).HasColumnType("nvarchar").HasMaxLength(250);

        }

    }
}
