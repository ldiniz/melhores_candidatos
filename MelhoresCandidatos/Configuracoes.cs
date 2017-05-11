using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelhoresCandidatos
{
    class Configuracoes
    {
        private int proporcaoResultados;
        private int quantidadeVagas;

        public Configuracoes()
        {
            proporcaoResultados = 3;
            quantidadeVagas = 1;
        }

        public int getProporcaoResultados()
        {
            return proporcaoResultados;
        }

        public void setProporcaoResultados(int value)
        {
            proporcaoResultados = value;
        }

        public int getQuantidadeVagas()
        {
            return quantidadeVagas;
        }

        public void setQuantidadeVagas(int value)
        {
            quantidadeVagas = value;
        }

        public int getQuantidadeResultados()
        {
            return quantidadeVagas * proporcaoResultados;
        }
    }
}
