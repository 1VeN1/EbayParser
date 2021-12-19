namespace EbayParser
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Sellers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sellers()
        {
            Product = new HashSet<Products>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Nickname { get; set; }
        [NotMapped]
        public int Stars { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Products> Product { get; set; }
    }
}
