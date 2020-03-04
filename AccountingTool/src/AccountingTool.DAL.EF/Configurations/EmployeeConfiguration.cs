using System;
using System.Collections.Generic;
using System.Text;
using AccountingTool.DAL.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountingTool.DAL.EF.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasOne(c => c.Position)
                .WithMany(c => c.Employees)
                .HasForeignKey(c => c.PositionId);

            builder.HasOne(c => c.Department)
                .WithMany(c => c.Employees)
                .HasForeignKey(c => c.DepartmentId);

            builder.HasMany(c => c.ItemAccountings)
                .WithOne(c => c.Employee)
                .HasForeignKey(c => c.EmployeeId);
        }
    }
}
