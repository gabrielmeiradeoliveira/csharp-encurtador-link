using encurtador_link.Models;
using encurtador_link.ViewModel;

namespace encurtador_link.Controllers;

public class EncurtadorService : IEncurtadorService
{
    public Encurtador EncurtarLink(EncurtadorViewModel encurtador)
    {
        var codigo = GerarToken(encurtador.Link);

        Encurtador model = new Encurtador()
        {
            Codigo = codigo,
            LinkOriginal = encurtador.Link,
            Data = DateTime.UtcNow
        };

        return model;
    }
    
    private string GerarToken(string link)
    {
        var caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        var random = new Random();
        return new string(new char[8].Select(o => caracteres[random.Next(caracteres.Length)]).ToArray());
    }
}
