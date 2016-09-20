namespace Assignment1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.addresses")]
    public partial class addresses
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public addresses()
        {
            employee_addresses = new HashSet<employee_addresses>();
            headquarter_addresses = new HashSet<headquarter_addresses>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string postal_code { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string country { get; set; }

        [StringLength(25)]
        public string street { get; set; }

        [StringLength(4)]
        public string number { get; set; }

        [StringLength(25)]
        public string city { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<employee_addresses> employee_addresses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<headquarter_addresses> headquarter_addresses { get; set; }
    }
}
