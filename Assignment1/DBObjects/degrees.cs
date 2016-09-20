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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public degrees()
        {
            employee_degrees = new HashSet<employee_degrees>();
        }

        public int id { get; set; }

        [StringLength(30)]
        public string course { get; set; }

        [StringLength(30)]
        public string school { get; set; }

        [StringLength(20)]
        public string level { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<employee_degrees> employee_degrees { get; set; }
    }
}
