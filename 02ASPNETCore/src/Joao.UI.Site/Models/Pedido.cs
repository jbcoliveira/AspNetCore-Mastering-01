using System;

namespace Joao.UI.Site.Models
{
    public class Pedido
    {
        public Pedido()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

        public string Descricao { get; set; }

        public DateTime DataPedido { get; set; }


    }
}