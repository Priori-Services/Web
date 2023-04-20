namespace PRIORI_SERVICES_WEB.Data;

public class PostBlog
{
    public int id_post { get; set; }
    public int id_autor { get; set; }
    public int id_categoria { get; set; }
    public DateTime data_criacao { get; set; }
    public string? titulo { get; set; } = null;
    public string? descricao { get; set; } = null;
    public string? conteudo { get; set; } = null;
}