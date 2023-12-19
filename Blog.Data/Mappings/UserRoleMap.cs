using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");


            builder.HasData(
                new AppUserRole
                {
                    UserId = Guid.Parse("372F18FE-FE3F-4826-A47E-8E77260F684B"),
                    RoleId = Guid.Parse("36D41F1D-AA2F-44F1-99CC-3F59BFEC10F3")
                },
                new AppUserRole
                {
                    UserId = Guid.Parse("4A0F8924-5B95-427E-8E19-C19225C1B880"),
                    RoleId = Guid.Parse("5A3993BB-7489-46BA-AB9D-812360C815BA")
                }
                );
        }
    }
}
