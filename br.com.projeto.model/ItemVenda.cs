using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Vendas_Fatec.br.com.projeto.model
{
    public class ItemVenda
    {
        //Atributos e propriedades
        public int id { get; set; }

        public int venda_id { get; set; }

        public int produto_id { get; set; }

        public int qtd { get; set; }

        public decimal subtotal { get; set; }

    }
}
