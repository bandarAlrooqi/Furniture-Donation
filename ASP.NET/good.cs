namespace ASP.NET
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class good
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        [Required]
        [StringLength(50)]
        public string user { get; set; }

        public virtual user user1 { get; set; }
    }
}
