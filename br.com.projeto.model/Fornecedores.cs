using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Vendas_Fatec.br.com.projeto.model
{
    public class Fornecedores : Cliente //Colocando Herança da classe Cliente com os : 
    {
        //Atributos + getter e setter
        public string cnpj { get; set; }
    }
}
