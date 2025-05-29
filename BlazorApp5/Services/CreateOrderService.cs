using DataBase;
using Microsoft.AspNetCore.Connections;
using Models.DAL.Models;

namespace BlazorApp5.Services;

public class CreateOrderService
{
    private DatabaseConnectionContext ef = new ();
    
    public string Name { get; set; }
    public string Surname { get; set; }
    public string? MiddleName { get; set; }
    public string PhoneNumber { get; set; }
    public string CarBrand { get; set; }

    public void CreateOrder(Client client)
    {
        ef.Clients.Add(client);
        ef.SaveChanges();
    }
}