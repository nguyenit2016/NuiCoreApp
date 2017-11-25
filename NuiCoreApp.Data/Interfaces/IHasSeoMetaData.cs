namespace NuiCoreApp.Data.Interfaces
{
    public interface IHasSeoMetaData
    {
        string SeoPageTitle { get; set; }
        string SeoAlias { get; set; }
        string SeoKeyWord { get; set; }
        string SeoDescription { get; set; }
    }
}