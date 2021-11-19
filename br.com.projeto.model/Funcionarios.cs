using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Vendas_Fatec.br.com.projeto.model
{
    public class Funcionarios : Cliente
    {
        //Atributos + getter e setter
        public string senha { get; set; }
        public string cargo { get; set; }
        public string nivel { get; set; }

    }
}
