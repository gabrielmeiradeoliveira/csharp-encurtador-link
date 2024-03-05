using encurtador_link.Models;
using encurtador_link.ViewModel;

namespace encurtador_link.Controllers;

public interface IEncurtadorService
{
    Encurtador EncurtarLink(EncurtadorViewModel encurtador);
}