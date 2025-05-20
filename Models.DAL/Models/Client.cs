using System.ComponentModel.DataAnnotations;
using BlazorApp5.Enums;

namespace BlazorApp5.Models;

public class Client
{
    [Key]public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string? MiddleName { get; set; }
    public string PhoneNumber { get; set; }
    public VehicleType VehicleType { get; set; }
}