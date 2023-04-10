//.Net >=6 aceita instruções de ordens superiores

void ConfiguracoesIniciais()
{
    // Coloca o encoding para UTF8 para exibir acentuação
    Console.OutputEncoding = System.Text.Encoding.UTF8;
}
void Loop()
{
    Console.WriteLine("Iniciado.");

    var estacionamento = new Estacionamento.Estacionamento();
    Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");

    estacionamento.precoInicial = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Agora digite o preço por hora:");
    estacionamento.precoPorHora = Convert.ToDecimal(Console.ReadLine());

    Boolean sair = false;
    var tela = TELAS.INICIO;

    do
    {
        Console.WriteLine("Digite a sua opção:");
        foreach (var item in Enum.GetValues(typeof(TELAS)))
        {
            Console.WriteLine($"{(int)item} - {Enum.GetName(typeof(TELAS),item)}");
        }

        var telaNum = -1;
        int.TryParse(Console.ReadLine(), out telaNum);

        Console.Clear();
        switch (telaNum)
        {
            case (int)TELAS.INICIO:
                break;
            case (int)TELAS.ADICIONAR:
                estacionamento.AdicionarVeiculo();
                break;
            case (int)TELAS.LISTAR:
                estacionamento.ListarVeiculos();
                break;
            case (int)TELAS.PEGAR:
                estacionamento.PegarVeiculo();
                break;
            case (int)TELAS.REMOVER:
                estacionamento.RemoverVeiculo();
                break;
            case (int)TELAS.SAIR:
                sair = true;
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    } while (!sair);
    Console.WriteLine("Terminado.");
}



ConfiguracoesIniciais();
Loop();
Console.WriteLine("Até breve, digite qualquer tecla para sair.");
Console.ReadKey();
enum TELAS { INICIO, ADICIONAR, LISTAR, PEGAR, REMOVER, SAIR };