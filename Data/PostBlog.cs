using System.ComponentModel.DataAnnotations.Schema;

namespace PRIORI_SERVICES_WEB.Data.Model;

[Table("tblPostBlog")]
public class PostBlog
{
    [Column(TypeName = "int")]
    public int id_post { get; set; }
    [Column(TypeName = "int")]
    public int id_autor { get; set; }
    [Column(TypeName = "int")]
    public int id_categoria { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime data_criacao { get; set; }
    [Column(TypeName = "varchar(100)")]
    public string? titulo { get; set; } = null;
    [Column(TypeName = "varchar(200)")]
    public string? descricao { get; set; } = null;
    [Column(TypeName = "varchar(2000)")]
    public string? conteudo { get; set; } = null;
}
