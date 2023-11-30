using System;
using System.Collections.Generic;
using System.Text;

namespace Gestão_de_funcionarios
{
    public class Assistente{
        //Permite criar o toString dentro do assistente.
        public Funcionario AtribFuncionario { get; set; }
        public String Gestores { get; set; }
        public Assistente() { }
        public Assistente(int idF, string nome, double salario, string cargo, string gestor){
            //criacao do obj funcionario
            Funcionario atributo = new Funcionario(idF, nome, salario, cargo);
            //atribuição do obj ao atributo de classe
            AtribFuncionario = atributo;
            //Adicionais
            Gestores = gestor;
        }

        public string Print(){
            return AtribFuncionario.ToString() + Gestores;//Busca os atributos do assistente + gestores
        }
    }
}