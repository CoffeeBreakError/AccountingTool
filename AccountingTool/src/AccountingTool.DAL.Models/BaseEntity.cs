using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountingTool.DAL.Models
{
    public class BaseEntity : IBaseEntity, ISoftDeletable
    {
        public Guid Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}