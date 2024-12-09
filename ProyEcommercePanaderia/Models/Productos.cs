using System.ComponentModel.DataAnnotations;

namespace ProyEcommercePanaderia.Models
{
    public class Productos
    {
        [Display(Name = "Codigo")]
        public string cod_prod { get; set; }
        
        [Display(Name = "Nombre del Producto")]
        public string nom_prod { get; set; }
        
        [Display(Name = "Precio")]
        public decimal pre_prod { get; set; }
        
        [Display(Name = "Stock")]
        public int stk_prod { get; set; }
    }
}
