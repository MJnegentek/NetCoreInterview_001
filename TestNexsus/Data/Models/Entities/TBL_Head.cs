using System;
using System.Collections.Generic;

namespace TestNexsus.Data.Models.Entities;

public partial class TBL_Head
{
    public int id_Company { get; set; }

    public int id_Station { get; set; }

    public int id_Head { get; set; }

    public string? df_Head { get; set; }

    public string? df_Observacion { get; set; }

    public int? id_CreatedBy { get; set; }

    public DateTime? df_CreatedDate { get; set; }

    public virtual ICollection<TBL_Detail> TBL_Detail { get; set; } = new List<TBL_Detail>();
}
