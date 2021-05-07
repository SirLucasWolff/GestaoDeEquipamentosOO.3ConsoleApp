using GestaoDeEquipamentosOO._3ConsoleApp.Controladores;
using GestaoEquipamentos.ConsoleApp.Controladores;
using System;

namespace GestaoEquipamentos.ConsoleApp.Telas
{
    internal class TelaSolicitante 
    {
        private ControladorSolicitante Controlador;     
        private TelaSolicitante telaSelecionada;
        private TelaSolicitante telaSolicitante;
        private ControladorSolicitante controladorSolicitante;
        private object equipamento;

        public TelaSolicitante(TelaSolicitante telaSolicitante)
        {
            this.telaSolicitante = telaSolicitante;
        }

        

        public string ObterOpcao()
        {
            Console.WriteLine("Digite 1 para inserir um novo solicitante");
            Console.WriteLine("Digite 2 para visualizar os solicitantes");
            Console.WriteLine("Digite 3 para editar um solicitante");
            Console.WriteLine("Digite 4 para excluir um solicitante");

            Console.WriteLine("Digite S para sair");

            string opcao = Console.ReadLine();

            return opcao;

            if (opcao == "1")
            {
                Console.WriteLine("Digite o nome do Solicitante");
                

                opcao = Console.ReadLine();
                if (opcao.Length <= 6)
                {
                    
                    Console.WriteLine("Quantidade de caracteres inválidas");

                    Console.WriteLine("Digite o nome do equipamento");

                    Console.ReadLine();
                }

                Console.WriteLine("Digite o email do solicitante");
                opcao = Console.ReadLine();

                Console.WriteLine("Digite o número de telefone do Solicitante");
                opcao = Console.ReadLine();

                opcao = new ControladorSolicitante(controladorSolicitante()); 
            }

            if (opcao == "2")
            {
                ControladorSolicitante.ReferenceEquals();
            }

            if (opcao == "3")
            {

            }
        }

        
    }
}