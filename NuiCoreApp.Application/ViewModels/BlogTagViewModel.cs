namespace NuiCoreApp.Application.ViewModels
{
    public class BlogTagViewModel
    {
        public int Id { get; set; }
        public int BlogId { set; get; }
        public string TagId { set; get; }

        public BlogViewModel Blog { set; get; }

        public TagViewModel Tag { set; get; }
    }
}