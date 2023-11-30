using System;
using System.Globalization;

namespace Gestão_de_funcionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel
            int rp;
            bool verifica = false;
            //variavel da classe empresa(traz todos os metodos da classe empresa)//
            Empresa e = new Empresa();

            do{
                do{
                    Console.WriteLine("---------- MENU PRINCIPAL ----------");
                    Console.WriteLine("1 - Adicionar funcionario");
                    Console.WriteLine("2 - Relatorio dos salarios");
                    Console.WriteLine("3 - Funcionarios com maior salario por categoria");
                    Console.WriteLine("4 - Pesquisar funcionario por ID");
                    Console.WriteLine("5 - Lista funcionarios");
                    Console.WriteLine("6 - Sair do programa");
                    Console.Write("Resposta: ");
                    if (int.TryParse(Console.ReadLine(), out rp)) ;//limita em valores inteiros
                    //Adicional
                    Console.Clear();
                } while (rp < 1 || rp > 6);

                switch (rp){
                    case 1:
                        e.AddFuncionario();
                        Console.Clear();
                        break;

                    case 2:
                        do{
                            rp = 0;
                            do{
                                Console.WriteLine("---------- MENU SALARIOS ----------");
                                Console.WriteLine("1 - Salario Total Diretores");
                                Console.WriteLine("2 - Salario Total Engenheiros");
                                Console.WriteLine("3 - Salario Total Assistentes");
                                Console.WriteLine("4 - Salario Total");
                                Console.WriteLine("5 - Voltar ao menu principal");
                                Console.Write("Resposta: ");
                                if (int.TryParse(Console.ReadLine(), out rp)) ;//limita em valores inteiros
                                //Adicional
                                Console.Clear();
                            } while (rp < 1 || rp > 5);

                            switch (rp){
                                case 1:
                                    Console.WriteLine("---------- SALARIO DIRETOR ----------");
                                    Console.Write("Total de Salarios pagos: " + e.diretorSalarios());
                                    //Adicional
                                    Console.ReadKey();//Pausa o programa.
                                    Console.Clear();
                                    break;
                                case 2:
                                    Console.WriteLine("---------- SALARIO ENGENHEIRO ----------");
                                    Console.Write("Total de Salarios pagos: " + e.engenheiroSalarios());
                                    //Adicional
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 3:
                                    Console.WriteLine("---------- SALARIO ASSISTENTE ----------");
                                    Console.Write("Total de Salarios pagos: " + e.assistenteSalarios());
                                    //Adicional
                                    Console.ReadKey();//Pausa o programa.
                                    Console.Clear();
                                    break;
                                case 4:
                                    Console.WriteLine("---------- SALARIO GERAIS ----------");
                                    Console.Write("Total de Salarios pagos: " + e.totalSalarios());
                                    //Adicional
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 5:
                                    verifica = true;
                                    break;
                            }
                        } while (verifica == false);
                        verifica = false;//Volta a colocar como falso para nao quebrar o programa.
                        break;

                    case 3:
                        do
                        {
                            rp = 0;
                            do
                            {
                                Console.WriteLine("--- MENU SALARIOS MAI ALTOS POR CATEGORIA ---");
                                Console.WriteLine("1 - Diretores");
                                Console.WriteLine("2 - Engenheiros");
                                Console.WriteLine("3 - Assistentes");
                                Console.WriteLine("4 - Voltar ao menu principal");
                                Console.Write("Resposta: ");
                                if (int.TryParse(Console.ReadLine(), out rp)) ;//limita em valores inteiros
                                //Adicional
                                Console.Clear();
                            } while (rp < 1 || rp > 4);

                            switch (rp)
                            {
                                case 1:
                                    Console.Write("---------- SALARIO DIRETORES ----------");
                                    e.diretorSalariosAlto();
                                    //Adicional
                                    Console.ReadKey();//Pausa o programa.
                                    Console.Clear();
                                    break;
                                case 2:
                                    Console.Write("---------- SALARIO ENGENHEIROS ----------");
                                    e.engenheiroSalariosAlto();
                                    //Adicional
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 3:
                                    Console.Write("---------- SALARIO ASSISTENTES ----------");
                                    e.assistenteSalariosAlto();
                                    //Adicional
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 4:
                                    verifica = true;
                                    break;
                            }
                        } while (verifica == false);
                        verifica = false;//Volta a colocar como falso para nao quebrar o programa.
                        break;

                    case 4:
                        do
                        {
                            rp = 0;
                            do
                            {
                                Console.WriteLine("--- MENU PESQUISA POR ID ---");
                                Console.WriteLine("1 - Diretores");
                                Console.WriteLine("2 - Engenheiros");
                                Console.WriteLine("3 - Assistentes");
                                Console.WriteLine("4 - Voltar ao menu principal");
                                Console.Write("Resposta: ");
                                if (int.TryParse(Console.ReadLine(), out rp)) ;//limita em valores inteiros
                                //Adicional
                                Console.Clear();
                            } while (rp < 1 || rp > 4);

                            switch (rp)
                            {
                                case 1:
                                    Console.WriteLine("---------- DIRETOR ----------");
                                    e.pesquisaDiretor();
                                    //Adicional
                                    Console.ReadKey();//Pausa o programa.
                                    Console.Clear();
                                    break;
                                case 2:
                                    Console.WriteLine("---------- ENGENHEIRO ----------");
                                    e.pesquisaEngenheiro();
                                    //Adicional
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 3:
                                    Console.WriteLine("---------- ASSISTENTE ----------");
                                    e.pesquisaAssistente();
                                    //Adicional
                                    Console.ReadKey();//Pausa o programa.
                                    Console.Clear();
                                    break;
                                case 4:
                                    verifica = true;
                                    break;
                            }
                        } while (verifica == false);
                        verifica = false;//Volta a colocar como falso para nao quebrar o programa.
                        break;
                    case 5:
                        Console.WriteLine("---------- FUNCIONARIOS ----------");
                        e.listaFuncionarios();
                        //Adicional
                        Console.ReadKey();//Pausa o programa.
                        Console.Clear();
                        break;
                    case 6:
                        verifica = true;
                        break;
                }
            } while (verifica == false);
        }
    }
}