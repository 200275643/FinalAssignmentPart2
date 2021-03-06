namespace FinalAssignment_Part2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cart
    {
        [Key]
        public int RecordId { get; set; }

        public string CartId { get; set; }

        public int Count { get; set; }

        public DateTime DateCreated { get; set; }

        public int ID { get; set; }

        public virtual ProductModel ProductModel { get; set; }
    }
}
