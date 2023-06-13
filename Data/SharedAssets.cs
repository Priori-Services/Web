namespace PRIORI_SERVICES_WEB.Data.Model;

public static class SharedAssets
{
    public static int id_selecionado { get; set; }
    public static int id_blog { get; set; }
    public static PostBlog? PostMain { get; set; }
    public static CategoriaBlog? CategoriaMain { get; set; }
    public static int? IsUserConsultor { get; set; } = null;
}
