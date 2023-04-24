namespace PRIORI_SERVICES_WEB.Data.Model;

public sealed class FaqItem
{
    public FaqItem()
    {
        UniqueId = Guid.NewGuid();
        HeadingId = Guid.NewGuid();
    }
    public Guid HeadingId { get; }
    public Guid UniqueId { get; }
    public String? Header { get; set; }
    public String? Body { get; set; }
}
