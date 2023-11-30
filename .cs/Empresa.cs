using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Numerics;
using System.Text;

namespace Gestão_de_funcionarios
{
    public class Empresa{

        int idD = 0, idE = 0, idA = 0;
        Diretor[] diretores = new Diretor[10];//Limite de 10 diretores.
        Engenheiro[] engenheiros = new Engenheiro[20];//Limite de 20 engenheiros.
        Assistente[] assistentes = new Assistente[70];//Limite de 70 assistentes.


        //------------------------------------------- ADD TRABALHADOR ------------------------------------------------//
        public void AddFuncionario(){
            int rp;
            double salario;
            string nome, cargo, departamento, projeto, gestor;
            bool verifica = false;

            //---------------------- SUB MENU ----------------------//
            do{
                do{
                    Console.WriteLine("---------- MENU ADD FUNCIONARIO ----------");
                    Console.WriteLine("1 - Adicionar Diretor");
                    Console.WriteLine("2 - Adicionar Engenheiro");
                    Console.WriteLine("3 - Adicionar Assistente");
                    Console.WriteLine("4 - Voltar ao menu principal");
                    Console.Write("Resposta: ");
                    if (int.TryParse(Console.ReadLine(), out rp)) ;//limita em valores inteiros
                    Console.Clear();
                } while (rp < 1 || rp > 4);

                switch (rp){
                    case 1://Diretor
                        if (idD < 10){
                            //Nome
                            Console.Write("Nome: ");
                            nome = Console.ReadLine();
                            //Salario
                            Console.Write("Salario: ");
                            if (double.TryParse(Console.ReadLine(), out salario)) ;
                            //Cargo
                            cargo = "Diretor";
                            Console.WriteLine("Cargo: " + cargo);
                            //Departamento
                            Console.Write("Departamento: ");
                            departamento = Console.ReadLine();
                            //ID
                            diretores[idD]= new Diretor(idD, nome, salario, cargo, departamento);
                            Console.WriteLine("ID: " + idD);
                            idD++;//Aumente o id
                            //Adicional
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 2://Engenheiro
                        if (idE < 20){
                            //Nome
                            Console.Write("Nome: ");
                            nome = Console.ReadLine();
                            //Salario
                            Console.Write("Salario: ");
                            if (double.TryParse(Console.ReadLine(), out salario)) ;
                            //Cargo
                            cargo = "Engenheiro";
                            Console.WriteLine("Cargo: " + cargo);
                            //Departamento
                            Console.Write("Departamento: ");
                            projeto = Console.ReadLine();
                            //ID
                            engenheiros[idE] = new Engenheiro(idE, nome, salario, cargo, projeto);
                            Console.WriteLine("ID: " + idE);
                            idE++; //Aumente o id
                            //Adicional
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break; 
                    case 3: //Assistente
                        if (idA < 70){
                            //Nome
                            Console.Write("Nome: ");
                            nome = Console.ReadLine();
                            //Salario
                            Console.Write("Salario: ");
                            if (double.TryParse(Console.ReadLine(), out salario));
                            //Cargo
                            cargo = "Assistente";
                            Console.WriteLine("Cargo: " + cargo);
                            //Departamento
                            Console.Write("Departamento: ");
                            gestor = Console.ReadLine();
                            //ID
                            assistentes[idA] = new Assistente(idA, nome, salario, cargo, gestor);
                            Console.WriteLine("ID: " + idA);
                            idA++;// Aumente o id
                            //Adicional
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 4:
                        verifica = true;
                        break;
                }
            } while (verifica == false);
        }



        //------------------------------------------- SALARIOS ------------------------------------------------//
        //---------------------- DIRETOR ----------------------//
        public double diretorSalarios(){
            double slDiretor = 0;
            for (int i = 0; i < idD; i++){//For diretores
                slDiretor += diretores[i].AtribFuncionario.Salario;
            }
            return slDiretor;
        }
        //---------------------- ENGENHEIRO ----------------------//
        public double engenheiroSalarios(){
            double slEngenheiro = 0;
            for (int i = 0; i < idE; i++){//For engenheiro
                slEngenheiro += engenheiros[i].AtribFuncionario.Salario;
            }
            return slEngenheiro;
        }
        //---------------------- ASSISTENTE ----------------------//
        public double assistenteSalarios(){
            double slAssistente = 0;
            for (int i = 0; i < idA; i++){//For assistente
                slAssistente += assistentes[i].AtribFuncionario.Salario;
            }
            return slAssistente;
        }
        //---------------------- TOTAL SALARIO ----------------------//
        public double totalSalarios(){
            double valorTT = 0;
            valorTT = assistenteSalarios() + engenheiroSalarios() + diretorSalarios();
            return valorTT;
        }



        //------------------------------------------- SALARIOS MAIS ALTO ------------------------------------------------//
        //---------------------- DIRETOR ----------------------//
        public void diretorSalariosAlto(){
            double aux = 0;
            for (int i = 0; i < idD; i++){//For diretores
                if (aux < diretores[i].AtribFuncionario.Salario){
                    aux = diretores[i].AtribFuncionario.Salario;
                }
            }

            for (int i = 0; i < idD; i++){
                if (aux == diretores[i].AtribFuncionario.Salario){
                    Console.WriteLine(diretores[i].AtribFuncionario);
                    Console.WriteLine("Departamento: " + diretores[i].Departamentos);
                }
            }
        }
        //---------------------- ENGENHEIRO ----------------------//
        public void engenheiroSalariosAlto(){
            double aux = 0;
            for (int i = 0; i < idE; i++){//For engenheiro
                if (aux < engenheiros[i].AtribFuncionario.Salario){
                    aux = engenheiros[i].AtribFuncionario.Salario;
                }
            }

            for (int i = 0; i < idE; i++){
                if (aux == engenheiros[i].AtribFuncionario.Salario){
                    Console.WriteLine(engenheiros[i].AtribFuncionario);
                    Console.WriteLine("Departamento: " + engenheiros[i].Projetos);
                }
            }
        }
        //---------------------- ASSISTENTE ----------------------//
        public void assistenteSalariosAlto(){
            double aux = 0;
            for (int i = 0; i < idA; i++){//For assistente
                if (aux < assistentes[i].AtribFuncionario.Salario){
                    aux = assistentes[i].AtribFuncionario.Salario;
                }
            }

            for (int i = 0; i < idA; i++){
                if (aux == assistentes[i].AtribFuncionario.Salario){
                    Console.WriteLine(assistentes[i].AtribFuncionario);
                    Console.WriteLine("Departamento: " + assistentes[i].Gestores);
                }
            }
        }



        //------------------------------------------- PESQUISAR FUNCIONARIO ------------------------------------------------//
        //---------------------- DIRETOR ----------------------//
        public void pesquisaDiretor(){
            int idPs = 0;

            Console.Write("Qual id deseja pesquisar: ");
            if (int.TryParse(Console.ReadLine(), out idPs));//limita em valores inteiros

            for (int i = 0; i < idD; i++){//For diretores
                if (idPs == diretores[i].AtribFuncionario.IdF){
                    Console.WriteLine(diretores[i].AtribFuncionario);
                    Console.WriteLine("Departamento: " + diretores[i].Departamentos);
                }
            }
        }
        //---------------------- ENGENHEIRO ----------------------//
        public void pesquisaEngenheiro(){
            int idPs = 0;

            Console.Write("Qual id deseja pesquisar: ");
            if (int.TryParse(Console.ReadLine(), out idPs));//limita em valores inteiros

            for (int i = 0; i < idE; i++){//For diretores
                if (idPs == engenheiros[i].AtribFuncionario.IdF){
                    Console.WriteLine(engenheiros[i].AtribFuncionario);
                    Console.WriteLine("Departamento: " + engenheiros[i].Projetos);
                }
            }
        }
        //---------------------- ASSISTENTE ----------------------//
        public void pesquisaAssistente(){
            int idPs = 0;

            Console.Write("Qual id deseja pesquisar: " );
            if (int.TryParse(Console.ReadLine(), out idPs));//limita em valores inteiros

            for (int i = 0; i < idA; i++){//For diretores
                if (idPs == assistentes[i].AtribFuncionario.IdF){
                    Console.WriteLine(assistentes[i].AtribFuncionario);
                    Console.WriteLine("Departamento: " + assistentes[i].Gestores);
                }
            }
        }

        //------------------------------------------- FUNCIONARIOS ------------------------------------------------//
        //---------------------- LISTA ----------------------//
        public void listaFuncionarios(){
            for (int i = 0; i < idD; i++) {//For diretores               
                Console.WriteLine(diretores[i].AtribFuncionario);
                Console.WriteLine("Departamento: " + diretores[i].Departamentos);
            }
            for (int i = 0; i < idE; i++){//For engenheiro               
                Console.WriteLine(engenheiros[i].AtribFuncionario);
                Console.WriteLine("Departamento: " + engenheiros[i].Projetos);
            }
            for (int i = 0; i < idA; i++){//For assistentes               
                Console.WriteLine(assistentes[i].AtribFuncionario);
                Console.WriteLine("Departamento: " + assistentes[i].Gestores);
            }
        }
    }
}