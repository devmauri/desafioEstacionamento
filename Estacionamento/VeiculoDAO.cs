using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento
{
    public class VeiculoDAO : iCRUD<Veiculo>
    {
        private VeiculoMOC moc;
        /// <summary>
        /// Classe concreta que implementa as ações do crud
        /// </summary>
        public VeiculoDAO(){
            this.moc = VeiculoMOC.Singleton();
        }
        bool iCRUD<Veiculo>.Adicionar(Veiculo item)
        {
            moc.Veiculos.Add(item);
            return true;
        }

        bool iCRUD<Veiculo>.Atualizar(Veiculo item)
        {
            if((((iCRUD<Veiculo>)this).Ler(item.Placa))==null){
                return false;
            }
            var temp = moc.Veiculos.Find(x => x.Placa.ToUpper() == item.Placa.ToUpper());
            temp = item;
            return true;

        }

        Veiculo iCRUD<Veiculo>.Ler(string id)
        {
            if(moc.Veiculos.Any(x => x.Placa.ToUpper() == id.ToUpper())){
                return moc.Veiculos.Find(x => x.Placa.ToUpper() == id.ToUpper());
            }
            return null;
        }

        List<Veiculo> iCRUD<Veiculo>.Listar()
        {
            return moc.Veiculos;
        }

        bool iCRUD<Veiculo>.Remover(Veiculo item)
        {
            return moc.Veiculos.Remove(item);
        }
    }
}