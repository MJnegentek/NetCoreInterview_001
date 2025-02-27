using TestNexsus.Services.Dto;

namespace TestNexsus.Repository.Legacy
{
    public interface ITestData_cls
    {

        List<TBL_DetailDTO_cls> getDetailByStation(int cmp, int stt);

    }
}
