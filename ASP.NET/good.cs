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

        public string Title { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }
        public string Image { get; set; }
        public string RequestedBy { get; set; } // store the id of the user in case of its requested by a user, otherwise null 
        [Required]
        [StringLength(50)]
        public string user { get; set; }

        public virtual user user1 { get; set; }
    }
}
