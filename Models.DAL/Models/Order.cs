using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlazorApp5.Models;

namespace Models.DAL.Models;

public class Order
{
    [Key]public int OrderID { get; set; }
    
    public int ClientUser { get; set; }
    [ForeignKey("ClientUser")]public Client? Client { get; set; }
    
    public int ServiceUser { get; set; }
    [ForeignKey("ServiceUser")]public Service? Service{ get; set; }
}