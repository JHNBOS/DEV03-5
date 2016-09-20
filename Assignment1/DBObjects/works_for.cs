namespace Assignment1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.works_for")]
    public partial class works_for
    {
        public int id { get; set; }

        [StringLength(25)]
        public string hq_name { get; set; }

        [StringLength(10)]
        public string emp_bsn { get; set; }

        public virtual headquarters headquarters { get; set; }
    }
}
