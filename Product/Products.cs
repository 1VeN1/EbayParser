namespace EbayParser
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("Product")]
    public partial class Products
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Price { get; set; }

        [Required]
        [StringLength(50)]
        public string Sales { get; set; }

        public int SellerID { get; set; }

        public virtual Sellers Sellers { get; set; }
    }
}
