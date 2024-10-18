#nullable disable
using panel_foroshgah.Enums;
namespace panel_foroshgah.Models;


public class Member : User
{

    public Member(string firstname,string lastname,string phonenumber,string nationalcode)
    {
        FirstName = firstname;
        LastName = lastname;
        PhoneNumber = phonenumber;
        NationalCode = nationalcode;
    }


  
   
    public string Password { get; set; }
    public string Address { get; set; }
   
    public DateOnly DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    
    public string FullName
    {
        get
        {
            return FirstName + " " + LastName;
        }

    }

    public void ChangFirstName(string newFirstName) =>FirstName = newFirstName;
    public void ChangLastName(string newLastName) => LastName = newLastName;
    public void ChangPhoneNumber(string newPhoneNumber) => PhoneNumber = newPhoneNumber;
    public void ChangNationalCode(string newNationalCode) => FirstName = newNationalCode;

}
