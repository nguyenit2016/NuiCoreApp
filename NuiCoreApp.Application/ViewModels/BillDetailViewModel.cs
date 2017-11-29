namespace NuiCoreApp.Application.ViewModels
{
    public class BillDetailViewModel
    {
        public int Id { get; set; }
        public int BillId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }
        public int ColorId { get; set; }
        public int SizeId { get; set; }

        public ProductViewModel Product { get; set; }

        public BillViewModel Bill { get; set; }

        public ColorViewModel Color { set; get; }

        public SizeViewModel Size { set; get; }
    }
}