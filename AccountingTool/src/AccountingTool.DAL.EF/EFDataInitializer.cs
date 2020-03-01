using AccountingTool.Common.Contracts;
using AccountingTool.DAL.EF.Context;

namespace AccountingTool.DAL.EF
{
    public class EFDataInitializer : IDataInitializer
    {
        private readonly ApplicationDbContext _context;

        public EFDataInitializer(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            throw new System.NotImplementedException();
        }
    }
}