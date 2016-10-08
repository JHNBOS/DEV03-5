namespace Assignment1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.degrees")]
    public partial class degrees
    {
        public int id { get; set; }

        [StringLength(30)]
        public string course { get; set; }

        [StringLength(30)]
        public string school { get; set; }

        [StringLength(20)]
        public string level { get; set; }

        [StringLength(10)]
        public string emp_bsn { get; set; }

        public virtual employees employees { get; set; }
    }
}
