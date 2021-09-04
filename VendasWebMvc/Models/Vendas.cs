using System;
using VendasWebMvc.Models.Enums;

namespace VendasWebMvc.Models
{
    public class Vendas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Qtde { get; set; }
        public VendaStatus Status { get; set; }
        public Vendedor Vendedor { get; set; }
        public Vendas()
        {
        }

        public Vendas(int id, DateTime data, double qtde, VendaStatus status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Qtde = qtde;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
