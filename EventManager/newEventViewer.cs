namespace EventManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newEventViewer")]
    public partial class newEventViewer
    {
        [Key]
        [StringLength(50)]
        public string Eventname { get; set; }

        [Required]
        [StringLength(50)]
        public string Location { get; set; }

        [Required]
        [StringLength(50)]
        public string Start { get; set; }

        [Required]
        [StringLength(50)]
        public string End { get; set; }
    }
}
