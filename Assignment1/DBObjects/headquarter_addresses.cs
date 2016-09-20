namespace Assignment1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.headquarter_addresses")]
    public partial class headquarter_addresses
    {
        public int id { get; set; }

        [StringLength(25)]
        public string hq_name { get; set; }

        [StringLength(10)]
        public string addr_postal { get; set; }

        [StringLength(30)]
        public string addr_country { get; set; }

        public virtual addresses addresses { get; set; }

        public virtual headquarters headquarters { get; set; }
    }
}
