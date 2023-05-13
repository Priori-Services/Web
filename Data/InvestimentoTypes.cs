namespace PRIORI_SERVICES_WEB.Data.Model;

public class Investimento
{
    public int id_investimento { get; set; }
    public Decimal id_riscoInvestimento { get; set; }
    public string? nome { get; set; } = String.Empty;
    public string? tipo_investimento { get; set; } = String.Empty;
    public Decimal rentabilidade_fixa { get; set; }
    public Decimal rentabilidade_variavel { get; set; }
    public DateTime data_atualizacao { get; set; }
    public DateTime vencimento { get; set; }
    public Decimal valor_minimo { get; set; }
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