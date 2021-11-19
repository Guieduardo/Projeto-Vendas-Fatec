using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Vendas_Fatec.br.com.projeto.model
{
    public class Produtos
    {
        //Atributos + getters e setters
        public int id { get; set; }

        public string descricao { get; set; }

        public decimal preco { get; set; }

        public int qtd_estoque { get; set; }

        public int for_id { get; set; } //ID do Fornecedor
    }
}
