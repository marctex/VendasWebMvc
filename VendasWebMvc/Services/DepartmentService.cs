using System.Collections.Generic;
using System.Linq;
using VendasWebMvc.Models;

namespace VendasWebMvc.Services
{
    public class DepartmentService
    {
        private readonly VendasWebMvcContext _context;

        public DepartmentService(VendasWebMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
