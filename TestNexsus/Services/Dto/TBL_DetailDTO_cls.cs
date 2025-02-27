namespace TestNexsus.Services.Dto
{
    public class TBL_DetailDTO_cls
    {

        public int id_Company { get; set; }

        public int id_Station { get; set; }

        public string df_Station { get; set; }
        public int id_Head { get; set; }

        public int id_Detail { get; set; }

        public string? df_Name { get; set; }

        public DateTime? df_CreatedDate { get; set; }
    }
}
