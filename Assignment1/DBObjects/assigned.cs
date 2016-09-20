namespace Assignment1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.assigned")]
    public partial class assigned
    {
        public int id { get; set; }

        [StringLength(25)]
        public string position_name { get; set; }

        public string project_id { get; set; }

        public virtual projects projects { get; set; }

        public virtual positions positions { get; set; }
    }
}
