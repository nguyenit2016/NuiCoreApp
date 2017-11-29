using System.ComponentModel.DataAnnotations;

namespace NuiCoreApp.Application.ViewModels
{
    public class ProductTagViewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }

        [StringLength(50)]
        public string TagId { get; set; }

        public ProductViewModel Product { get; set; }

        public TagViewModel Tag { get; set; }
    }
}