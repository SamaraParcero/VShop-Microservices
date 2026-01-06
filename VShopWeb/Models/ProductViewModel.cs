using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VShopWeb.Models;

public class ProductViewModel
{
    public int Id { get; set; }
   
    public string? Name { get; set; }

    
    public decimal Price { get; set; }
    

    public string? Description { get; set; }
  
    public long Stock { get; set; }
   
    public string? ImageURL { get; set; }
    public string? CategoryName { get; set; }
    public int CategoryId { get; set; }

    public int Quantity { get; set; } = 1;
}
