namespace ASP.NET
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("user")]
    public partial class user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user()
        {
            goods = new HashSet<good>();
        }

        [Required]
        public string Name { get; set; }

        [Key]
        [StringLength(50)]
        public string Email { get; set; }

        public string Address { get; set; }

        [Required]
        public string Type { get; set; }

        [StringLength(10)]
        public string phone { get; set; }

        [Required]
        public string Password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<good> goods { get; set; }
    }
}
