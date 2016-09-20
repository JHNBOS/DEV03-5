namespace Assignment1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.headquarters")]
    public partial class headquarters
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public headquarters()
        {
            headquarter_addresses = new HashSet<headquarter_addresses>();
            works_for = new HashSet<works_for>();
        }

        [Key]
        [StringLength(25)]
        public string name { get; set; }

        public int? rooms { get; set; }

        public decimal? rent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<headquarter_addresses> headquarter_addresses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<works_for> works_for { get; set; }
    }
}
