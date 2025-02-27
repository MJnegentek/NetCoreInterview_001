using TestNexsus.Repository.Legacy;
using TestNexsus.Services.Dto;
using TestNexsus.Services.Legacy;

namespace TestNexsus.Business
{
    public class TestBusiness_cls : ITestBusiness_cls
    {

        public readonly ITestData_cls data;
        public TestBusiness_cls(ITestData_cls _data)
        {
            data = _data;
        }

        public List<TBL_DetailDTO_cls> getDetailByStation(int cmp, int st)
        {
            return data.getDetailByStation(cmp, st);
        }
    }
}
