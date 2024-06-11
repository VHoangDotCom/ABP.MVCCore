using ABP.MVCCore.EntityFrameworkCore;

namespace ABP.MVCCore.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly MVCCoreDbContext _context;

        public TestDataBuilder(MVCCoreDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}