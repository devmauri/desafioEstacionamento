using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento
{
    /// <summary>
    /// Classe criada para reter informações.
    /// </summary>
    public class VeiculoMOC
    {
        public List<Veiculo> Veiculos{ get; set; }
        private static VeiculoMOC moc;
        private VeiculoMOC(){
            this.Veiculos = new List<Veiculo>();
        }
        public static VeiculoMOC Singleton(){
            if(moc==null){
                VeiculoMOC.moc = new VeiculoMOC();
            }
            return moc;
        }
    }
}