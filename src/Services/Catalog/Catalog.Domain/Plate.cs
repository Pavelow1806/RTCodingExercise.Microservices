using System.ComponentModel.DataAnnotations;

namespace Catalog.Domain
{
    public class Plate
    {
        public Guid Id { get; set; }

        public string? Registration { get; set; }

        [Display(Name = "Purchase Price")]
        public decimal PurchasePrice { get; set; }

        [Display(Name = "Sale Price")]
        public decimal SalePrice { get; set; }

        public string? Letters { get; set; }

        public int Numbers { get; set; }

        [Display(Name = "Markup Price")]
        public decimal MarkupPrice { get; set; }
    }
}