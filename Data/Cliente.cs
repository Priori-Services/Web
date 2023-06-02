using System.ComponentModel.DataAnnotations.Schema;

namespace PRIORI_SERVICES_WEB.Data.Model;

public enum Status { ATIVO, INATIVO }
public enum TipoInvestidor { mogus, }
public enum RespostaAssessoria { mogus, aceitou, recusou, cancelou }
public enum SituacaoAssessoria { mogus, ativa, inativa }

[Table("tblClientes")]
public class Cliente
{
    public string GetTipoInvestidorFromID() {
        switch (this.id_tipoinvestidor)
        {
            case 1:
                return "TODO";
            case 2:
                return "TODO";
            case 3:
                return "TODO";
            default:
                return "Não encontrado";
        }
    }

    [Column(TypeName = "int")]
    public int id_cliente { get; set; }

    [Column(TypeName = "int")]
    public int? id_tipoinvestidor { get; set; }

    [Column(TypeName = "int"), ForeignKey("Consultor")]
    public int? id_consultor { get; set; }

    [Column(TypeName = "varchar(40)")]
    public string? nome { get; set; }

    [Column(TypeName = "varchar(11)")]
    public string? cpf { get; set; }

    [Column(TypeName = "varchar(8)")]
    public string? status { get; set; }

    [Column(TypeName = "date")]
    public DateTime data_adesao { get; set; }

    [Column(TypeName = "numeric")]
    public float? pontuacao { get; set; }

    [Column(TypeName = "int")]
    public RespostaAssessoria? respostaAssessoria { get; set; }
    [Column(TypeName = "int")]
    public SituacaoAssessoria? situacaoAssessoria { get; set; }

    [Column(TypeName = "varchar(60)")]
    public string? endereco { get; set; }

    [Column(TypeName = "varchar(20)")]
    public string? dataNascimento { get; set; }

    [Column(TypeName = "varchar(25)")]
    public string? email { get; set; }

    [Column(TypeName = "varchar(200)")]
    public string? senhaSalt { get; set; }

    [Column(TypeName = "varchar(200)")]
    public string? senhaHash { get; set; }
}
