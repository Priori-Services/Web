namespace PRIORI_SERVICES_WEB.Data.Model;
public class ClienteDBO
{
    public int? id_tipoinvestidor { get; set; }
    public int? id_consultor { get; set; }
    public string? endereco { get; set; } = null;
    public string? nome { get; set; }
    public string? senha { get; set; }
    public string? cpf { get; set; }
    public string? email { get; set; }
    public string? telefone { get; set; }
}
