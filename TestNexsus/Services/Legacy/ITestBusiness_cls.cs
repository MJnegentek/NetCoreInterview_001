using TestNexsus.Services.Dto;

namespace TestNexsus.Services.Legacy
{
    public interface ITestBusiness_cls
    {

        List<TBL_DetailDTO_cls> getDetailByStation(int cmp, int st);

   
    }
}
