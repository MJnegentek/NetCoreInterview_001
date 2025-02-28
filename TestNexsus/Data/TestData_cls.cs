using TestNexsus.Data.Models;
using TestNexsus.Data.Models.Entities;
using TestNexsus.Repository.Legacy;
using TestNexsus.Services.Dto;

namespace TestNexsus.Data
{
    public class TestData_cls: ITestData_cls
    {

        private readonly TestContext _myTestDbContext;

        public TestData_cls(TestContext myTestContext)
        {
            _myTestDbContext = myTestContext;
        }


        public List<TBL_DetailDTO_cls>  getDetailByStation(int cmp,int st)
        {

            var query = (from dt in _myTestDbContext.TBL_Detail where dt.id_Company == cmp && dt.id_Station == st
                         select new TBL_DetailDTO_cls
                         {
                             id_Company = dt.id_Company,
                             id_Station = dt.id_Station,
                             id_Head=dt.id_Head,
                             id_Detail=dt.id_Detail,
                             //df_Station = (from station in _myTestDbContext.),
                             df_Name=dt.df_Name,
                             df_CreatedDate = dt.df_CreatedDate
                         }
                         ).Take(0);

            return query.ToList();
        }
    }
}
