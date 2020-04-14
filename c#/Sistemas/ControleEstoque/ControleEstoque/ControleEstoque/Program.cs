using System;
//informe todas as classes que serão utlizadas
using ControleEstoque.Entites;
using ControleEstoque.Entites.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque
{
    class Program
    {
        static void Main(string[] args)
        {

            //instacia a classe e definindo valores

            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);
        }
    }
    
}
