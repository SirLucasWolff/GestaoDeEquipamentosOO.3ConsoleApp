using GestaoEquipamentos.ConsoleApp.Controladores;
using GestaoEquipamentos.ConsoleApp.Telas;
using System;

namespace GestaoEquipamentos.ConsoleApp
{
    class Program
    {
        

        static void Main(string[] args)
        {
            ControladorEquipamento controladorEquipamento = new ControladorEquipamento();

            TelaEquipamento telaEquipamento = new TelaEquipamento(controladorEquipamento);

            ControladorChamado controladorChamado = new ControladorChamado(controladorEquipamento);

            TelaPrincipal telaPrincipal = new TelaPrincipal(
                controladorEquipamento, telaEquipamento, controladorChamado);

            while (true)
            {
                TelaBase telaSelecionada = telaPrincipal.ObterOpcao();

                if (telaSelecionada == null)
                    break;

                Console.Clear();

                Console.WriteLine(telaSelecionada.Titulo); Console.WriteLine();

                string opcao = telaEquipamento.ObterOpcao();

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                    continue;

                if (opcao == "1")
                    telaSelecionada.InserirNovoRegistro();

                else if (opcao == "2")
                {
                    telaSelecionada.VisualizarRegistros();
                    Console.ReadLine();
                }

                else if (opcao == "3")
                    telaSelecionada.EditarRegistro();

                else if (opcao == "4")
                    telaSelecionada.ExcluirRegistro();

                Console.Clear();
            }
        }
    }
}