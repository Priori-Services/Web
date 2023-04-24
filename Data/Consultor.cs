namespace PRIORI_SERVICES_WEB.Data.Model;

public sealed class Consultor
{
    public int id_consultor { get; set; }
    public DateTime data_contratacao { get; set; }
    public DateTime? data_demissao { get; set; }
    public string usuario { get; set; } = String.Empty;
    public string? cpf { get; set; }
    public string? email { get; set; }
    public string? telefone { get; set; }
    public string? status { get; set; }
    public string? senhaSalt { get; set; }
    public string? senhaHash { get; set; }
}
