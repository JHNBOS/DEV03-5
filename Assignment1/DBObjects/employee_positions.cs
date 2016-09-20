namespace Assignment1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.employee_positions")]
    public partial class employee_positions
    {
        public int id { get; set; }

        [StringLength(25)]
        public string name { get; set; }

        [StringLength(10)]
        public string emp_bsn { get; set; }

        public virtual employees employees { get; set; }

        public virtual positions positions { get; set; }
    }
}
