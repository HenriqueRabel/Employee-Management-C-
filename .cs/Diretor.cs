using System;
using System.Collections.Generic;
using System.Text;

namespace Gestão_de_funcionarios
{
    public class Diretor{
        public Funcionario AtribFuncionario { get; set; }
        public String Departamentos { get; set; }
        public Diretor() { }
        public Diretor(int idF, string nome, double salario, string cargo, string departamento){
            //criacao do obj funcionario
            Funcionario atributo = new Funcionario(idF, nome, salario, cargo);
            // atribuição do obj ao atributo de classe
            AtribFuncionario = atributo;
            //Adicionais
            Departamentos = departamento;  
        } 

        public string Print(){
            return AtribFuncionario.ToString() + Departamentos;//Busca os atributos do diretor + departamento
        }
    }
}