using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floricultura.classes
{
    internal class Produto
    {
        public string Id { get; set; }
        public double Valor { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public int Quantidade { get; set; }
        public string Fornecedor { get; set; }

        public Produto()
        {

        }

        public Produto(string id, double valor, string nome, string categoria, int quantidade,
        string fornecedor)
        {
            Id = id;
            Valor = valor;
            Nome = nome;
            Categoria = categoria;
            Quantidade = quantidade;
            Fornecedor = fornecedor;
            
        }           
        
    }
}
