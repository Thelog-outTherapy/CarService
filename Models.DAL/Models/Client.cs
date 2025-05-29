using System.ComponentModel.DataAnnotations;
using BlazorApp5.Enums;

namespace Models.DAL.Models;

public class Client
{
    [Key]public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string? MiddleName { get; set; }
    public string PhoneNumber { get; set; }
    public string CarBrand { get; set; }

    public Client(string name, string surname, string? middleName, string phoneNumber, string carBrand)
    {
        Name = name;
        Surname = surname;
        MiddleName = middleName;
        PhoneNumber = phoneNumber;
        CarBrand = carBrand;
    }

    public Client()
    {
        
    }
}