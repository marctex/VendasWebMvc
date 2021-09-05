using System.Collections.Generic;

namespace VendasWebMvc.Models.ViewModels
{
    public class VendedorFromViewModel
    {
        public Vendedor Vendedor { get; set; }
        public ICollection<Department>Departments { get; set; }
    }
}
