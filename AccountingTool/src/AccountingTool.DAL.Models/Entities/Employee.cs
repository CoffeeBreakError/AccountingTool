using System;

namespace AccountingTool.DAL.Models.Entities
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public Guid PositionId { get; set; }
        public Position Position { get; set; }
    }
}
