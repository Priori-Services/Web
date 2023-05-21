using System.ComponentModel.DataAnnotations.Schema;

namespace PRIORI_SERVICES_WEB.Data.Model;

[Table("tblCategoriaBlog")]
public class CategoriaBlog
{
    [Column(TypeName = "int")]
    public int id_categoria { get; set; }

    [Column(TypeName = "varchar(50)")]
    public string? nome_categoria { get; set; } = null;
}
