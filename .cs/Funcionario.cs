using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gestão_de_funcionarios
{
    public class Funcionario{
        public int IdF { get; set; }
        public double Salario { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }

        public Funcionario(){
            IdF = 0;
            Nome = string.Empty;
            Salario = 0;
            Cargo = string.Empty;            
        }

        public Funcionario(int idF, string nome, double salario, string cargo){
            IdF = idF;
            Nome = nome;
            Salario = salario;
            Cargo = cargo;
        }

        public override string ToString(){
            return  "\nID: " + IdF + 
                    "\nNome: " + Nome + 
                    "\nSalario: " + Salario+
                    "\nCargo: " + Cargo;
        }
    }
}