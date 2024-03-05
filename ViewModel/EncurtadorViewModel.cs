using System.ComponentModel.DataAnnotations;

namespace encurtador_link.ViewModel;

public class EncurtadorViewModel
{
    [Required] public string Link { get; set; }
}