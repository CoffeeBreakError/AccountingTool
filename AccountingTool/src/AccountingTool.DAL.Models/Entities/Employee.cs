using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AccountingTool.DAL.Models.Entities
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public Guid PositionId { get; set; }
        public Position Position { get; set; }

        public Guid? DepartmentId { get; set; }
        public Department Department { get; set; }

        public ICollection<ItemAccounting> ItemAccountings { get; set; }
    }
}
