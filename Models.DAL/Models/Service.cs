using System.ComponentModel.DataAnnotations;
using BlazorApp5.Enums;

namespace Models.DAL.Models;

public class Service
{
    [Key]public int Id { get; set; }
    public DateTime OrderDateTime { get; set; }
    public decimal Price { get; set; }
}