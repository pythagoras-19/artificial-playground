using System.ComponentModel.DataAnnotations;

namespace ArtificialPlayground.Models; 

public class Toy {
    public int Id { get; set; }
    
    [Required]
    [StringLength(100)]
    public string Name { get; set; }
    
    [Required]
    [StringLength(200)]
    public string Description { get; set; }
    
    [Range(0.01, 1000.00)]
    public decimal Price { get; set; }
    public string Category { get; set; }
}