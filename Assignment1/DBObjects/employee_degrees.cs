namespace Assignment1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.employee_degrees")]
    public partial class employee_degrees
    {
        public int id { get; set; }

        public int? degree_id { get; set; }

        [StringLength(10)]
        public string emp_bsn { get; set; }

        public virtual degrees degrees { get; set; }

        public virtual employees employees { get; set; }
    }
}
