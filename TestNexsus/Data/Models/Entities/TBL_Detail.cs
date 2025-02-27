using System;
using System.Collections.Generic;

namespace TestNexsus.Data.Models.Entities;

public partial class TBL_Detail
{
    public int id_Company { get; set; }

    public int id_Station { get; set; }

    public int id_Head { get; set; }

    public int id_Detail { get; set; }

    public string? df_Name { get; set; }

    public DateTime? df_CreatedDate { get; set; }

    public virtual TBL_Head TBL_Head { get; set; } = null!;
}
