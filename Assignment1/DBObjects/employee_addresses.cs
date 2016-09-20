namespace Assignment1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.employee_addresses")]
    public partial class employee_addresses
    {
        public int id { get; set; }

        [Required]
        [StringLength(10)]
        public string addr_postal { get; set; }

        [Required]
        [StringLength(30)]
        public string addr_country { get; set; }

        [StringLength(10)]
        public string emp_bsn { get; set; }

        public virtual addresses addresses { get; set; }

        public virtual employees employees { get; set; }
    }
}
