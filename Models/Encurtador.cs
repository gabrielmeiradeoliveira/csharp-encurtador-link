namespace encurtador_link.Models;

public class Encurtador
{
    public Guid Id { get; set; }
    public string LinkOriginal { get; set; }
    public string Codigo { get; set; }
    public DateTime Data { get; set; } = DateTime.Now;
}