using System;
using System.Collections.Generic;
using System.Text;

namespace Gestão_de_funcionarios
{
    public class Engenheiro{
        public Funcionario AtribFuncionario { get; set; }
        public String Projetos { get; set; }
        public Engenheiro() { }
        public Engenheiro(int idF, string nome, double salario, string cargo, string projeto){
            //criacao do obj funcionario
            Funcionario atributo = new Funcionario(idF, nome, salario, cargo);
            //atribuição do obj ao atributo de classe
            AtribFuncionario = atributo;
            //Adicionais
            Projetos = projeto;
        }

        public string Print(){
            return AtribFuncionario.ToString() + Projetos;//Busca os atributos do engenheiro + projetos
        }
    }
}