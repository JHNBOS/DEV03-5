namespace Assignment1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.working_on")]
    public partial class working_on
    {
        public int id { get; set; }

        public string emp_bsn { get; set; }

        public string project_id { get; set; }

        public virtual employees employees { get; set; }

        public virtual projects projects { get; set; }
    }
}
