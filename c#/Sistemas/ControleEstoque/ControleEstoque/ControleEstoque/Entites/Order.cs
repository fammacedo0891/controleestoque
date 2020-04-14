using System;
using ControleEstoque.Entites.Enums;

namespace ControleEstoque.Entites
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Moment.ToString("dd/MM/yyyy")
                + ", "
                + Status;
        }
    }

    
}
