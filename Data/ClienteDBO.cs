namespace PRIORI_SERVICES_WEB.Data.Model;
public sealed class ClienteDBO
{
    public int? id_tipoinvestidor { get; set; } = 0;
    public int? id_consultor { get; set; } = 1;
    public string? nome { get; set; } = String.Empty;
    public string? cpf { get; set; } = String.Empty;
    public string? status { get; set; } = "ATIVO";
    public RespostaAssessoria? respostaAssessoria { get; set; } = RespostaAssessoria.recusou;
    public SituacaoAssessoria? situacaoAssessoria { get; set; } = SituacaoAssessoria.ativa;
    public string? endereco { get; set; } = String.Empty;
    public string? dataNascimento { get; set; } = "00/00/0000";
    public string? email { get; set; } = String.Empty;
    public string? senha { get; set; } = String.Empty;
}
