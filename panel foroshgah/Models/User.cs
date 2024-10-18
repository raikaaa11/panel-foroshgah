#nullable disable
namespace panel_foroshgah.Models;

public class User
{
    public string FirstName { get;  set; }
    public string LastName { get;  set; }
    public string PhoneNumber { get;  set; }
    public string NationalCode { get;  set; }
    public string Email { get; set; }
    public string FullName
    {
        get
        {
            return FirstName + " " + LastName;
        }

    }
}
