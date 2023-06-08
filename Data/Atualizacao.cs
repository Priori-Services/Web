using System.ComponentModel.DataAnnotations.Schema;

namespace PRIORI_SERVICES_WEB.Data.Model;

[Table("tblAtualizacao")]
public class Atualizacao
{
    [Column(TypeName = "int")]
    public int id_atualizacao { get; set; }

    [Column(TypeName = "int")]
    [ForeignKey("tblConsultores")]
    public int id_consultor { get; set; }

    [Column(TypeName = "int"), ForeignKey("tblInvestimentos")]
    public int id_investimento { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? data_atualizacao { get; set; }

    [Column(TypeName = "numeric(8,4)")]
    public Decimal rentFixaAntiga { get; set; }

    [Column(TypeName = "numeric(8,2)")]
    public Decimal rentVarAntiga { get; set; }

    [Column(TypeName = "numeric(8,4)")]
    public Decimal rentFixaAtual { get; set; }

    [Column(TypeName = "numeric(8,2)")]
    public Decimal rentVarAtual { get; set; }
}
