using System.ComponentModel.DataAnnotations;
using BlazorApp5.Enums;

namespace BlazorApp5.Models;

public class Service
{
    [Key]public int Id { get; set; }
    public ServiceType ServiceType { get; set; }
    public DateOnly Date { get; set; }
    public TimeOnly Time { get; set; }
    public decimal Price { get; set; }
}