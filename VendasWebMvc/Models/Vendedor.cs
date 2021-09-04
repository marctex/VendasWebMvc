using System;
using System.Collections.Generic;
using System.Linq;

namespace VendasWebMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DataNasc { get; set; }
        public double SalarioBase { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<Vendas> Venda { get; set; } = new List<Vendas>();
        public Vendedor()
        {
        }

        public Vendedor(int id, string name, string email, DateTime dataNasc, double salarioBase, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            DataNasc = dataNasc;
            SalarioBase = salarioBase;
            Department = department;
        }

        public void AdicionaVenda(Vendas sr)
        {
            Venda.Add(sr);
        }

        public void RemoveVenda(Vendas sr)
        {
            Venda.Remove(sr);
        }

      
        public double TotalVenda(DateTime initial, DateTime final)
        {
            return Venda.Where(sr => sr.Data >= initial && sr.Data <= final).Sum(sr => sr.Qtde);
        }
    }
}
