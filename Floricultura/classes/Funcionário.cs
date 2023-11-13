using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floricultura.classes
{
    internal class Funcionário
    {
        public class Funcionario1
        {
            public int FuncionarioID { get; set; }
            public string Nome { get; set; }
            public string Cargo { get; set; }
            public double Salario { get; set; }
            public int CargaHoraria { get; set; }
            public string CPF { get; set; }
            public string Endereco { get; set; }
            public string Email { get; set; }
            public string Telefone { get; set; }
            public string RG { get; set; }
            public string CTPS { get; set; }


            public Funcionario1()
            {

            }

            public Funcionario1(int funcionarioID, string nome, string cargo, double salario, int cargaHoraria, string cpf, string endereco, string email, string telefone, string rg, string ctps)
            {
                FuncionarioID = funcionarioID;
                Nome = nome;
                Cargo = cargo;
                Salario = salario;
                CargaHoraria = cargaHoraria;
                CPF = cpf;
                Endereco = endereco;
                Email = email;
                Telefone = telefone;
                RG = rg;
                CTPS = ctps;
            }
        }
    }  
}
