#nullable disable
using panel_foroshgah.Enums;

namespace panel_foroshgah.Models;

public class Management : User
{
  
    public string Id { get; set; }
    public string Password { get; set; }
    public Gender Gender { get; set; }
    
}
