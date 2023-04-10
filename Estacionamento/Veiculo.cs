using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento
{
    public class Veiculo
    {
        public String Placa { get; set; }

        private DateTime entrada;
        public DateTime Entrada  { get { return this.entrada; } }

        public Veiculo(String placa){
            this.Placa = placa;
            this.entrada = DateTime.Now;
        }
        public Veiculo(String placa, DateTime entrada): this(placa){
            this.entrada = entrada;
        }

        public Decimal Permanencia(){
            var temp = DateTime.Now.Subtract(entrada);
            return Decimal.Round(new Decimal(temp.TotalHours),2);
        }

        public override string ToString()
        {
            String ret = "";
            ret += "Placa = " + Placa + "\t";
            ret += "Permanecia atual = " + Permanencia();
            return ret;
        }
    }
}