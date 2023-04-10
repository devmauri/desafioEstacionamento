using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento
{
    public class Estacionamento
    {
        public Decimal precoInicial, precoPorHora;
        private iCRUD<Veiculo> dados;
        public Estacionamento()
        {
            precoInicial = new Decimal();
            precoPorHora = new Decimal();
            dados = new VeiculoDAO();
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            var temp = Console.ReadLine();
            if (temp == null)
            {
                return;
            }
            dados.Adicionar(new Veiculo(temp));
        }

        public void PegarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para verificar seus dados");
            var temp = Console.ReadLine();
            if (temp == null)
            {
                return;
            }
            Console.WriteLine(dados.Ler(temp));
        }

        public void ListarVeiculos()
        {
            Console.WriteLine("Seguem os veiculos estacionados:");
            int index = 0;
            foreach (var veiculo in dados.Listar())
            {
                index++;
                Console.WriteLine($"\t{index}\t - {veiculo}.");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para ser removido.");
            var temp = Console.ReadLine();
            if (temp == null)
            {
                return;
            }
            var veiculo = dados.Ler(temp);
            if (veiculo == null)
            {
                Console.WriteLine($"PLACA inexistente - {temp}.");
                return;
            }

            temp = (dados.Remover(veiculo)) ? "Preço " + Total(veiculo) + ". Veiculo removido com sucesso!" 
                                            : "Falha ao remover veiculo!";
            Console.WriteLine(temp);
        }

        public Decimal Total(Veiculo veiculo){
            return Decimal.Round(veiculo.Permanencia()*precoPorHora +precoInicial,2);
        }
    }
}