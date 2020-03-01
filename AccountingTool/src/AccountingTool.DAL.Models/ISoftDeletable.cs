namespace AccountingTool.DAL.Models
{
    public interface ISoftDeletable
    {
        bool IsDeleted { get; set; }
    }
}