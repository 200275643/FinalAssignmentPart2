namespace FinalAssignment_Part2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderDetail
    {
        public int ID { get; set; }

        public int OrderDetailId { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public int OrderId { get; set; }

        public int? ProductModels_ID { get; set; }

        public virtual Order Order { get; set; }

        public virtual ProductModel ProductModel { get; set; }
    }
}
