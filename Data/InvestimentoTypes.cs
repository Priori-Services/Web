using System.ComponentModel.DataAnnotations.Schema;

namespace PRIORI_SERVICES_WEB.Data.Model;

[Table("tblInvestimentos")]
public class Investimento
{

    [Column(TypeName = "int")]
    public int id_investimento { get; set; }

    [Column(TypeName = "numeric")]
    public Decimal id_riscoInvestimento { get; set; }

    [Column(TypeName = "varchar(40)")]
    public string? nome { get; set; }

    [Column(TypeName = "varchar(5)")]
    public string? tipo_investimento { get; set; }

    [Column(TypeName = "numeric(8,4)")]
    public Decimal rentabilidade_fixa { get; set; }
    [Column(TypeName = "numeric(8,2)")]
    public Decimal rentabilidade_variavel { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime data_atualizacao { get; set; }
    [Column(TypeName = "date")]
    public DateOnly vencimento { get; set; }
    [Column(TypeName = "numeric(8,2)")]
    public Decimal valor_minimo { get; set; }
    [Column(TypeName = "numeric(3)")]
    public Decimal tempo_minimo { get; set; }
}

public class Carteira
{
    public int id_efetuacao { get; set; }
    public int id_cliente_carteira { get; set; }
    public int id_investimento { get; set; }
    public string? status { get; set; } = String.Empty;
    public Decimal rentabilidade_fixa { get; set; }
    public Decimal rentabilidade_variavel { get; set; }
    public Decimal valor_aplicado { get; set; }
    public DateTime data_encerramento { get; set; }
    public DateTime data_efetuacao { get; set; }
}
