using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleContaDeBar
{
    class ContaDeBAr
    {
        private decimal totalConta;
        private decimal totalPessoa;
        private decimal dezPorcento;
        private int quantidadePessoa;

        public ContaDeBAr()
        {
            totalConta = 0.00M;
            totalPessoa = 0.00M;

        }

        public decimal getTotalConta()
        {
            return totalConta;
        }

        public decimal getTotalPessoa()
        {
            return totalPessoa;
        }

        public decimal getDezPorcento()
        {
            return dezPorcento;
        }

        public void setTotalConta(decimal vUnitarioTbx, int qtdTbx)
        {
            this.totalConta = vUnitarioTbx * qtdTbx;
        }

        public void setTotalPessoa(int qtdPessoa)
        {
            this.totalPessoa = getTotalConta() / qtdPessoa;
        }
    }
}
