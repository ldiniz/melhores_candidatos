using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelhoresCandidatos
{
    public partial class Index : Form
    {
        Configuracoes conf;

        public Index()
        {
            InitializeComponent();
            conf = new Configuracoes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelBuscarCurriculos.Visible = true;
            panelResultados.Visible = false;
            panelHistoricoBuscas.Visible = false;
            panelConfiguracoes.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelBuscarCurriculos.Visible = false;
            panelResultados.Visible = false;
            panelHistoricoBuscas.Visible = true;
            panelConfiguracoes.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelBuscarCurriculos.Visible = false;
            panelResultados.Visible = false;
            panelHistoricoBuscas.Visible = false;
            panelConfiguracoes.Visible = true;
        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
            panelBuscarCurriculos.Visible = false;
            panelResultados.Visible = false;
            panelHistoricoBuscas.Visible = false;
            panelConfiguracoes.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            containerCargo.Controls.Add(new Label() { Text = "Type:", Anchor = AnchorStyles.Left, AutoSize = true });
        }

        private void buttonBuscarCurriculos_Click(object sender, EventArgs e)
        {
            int i;
            int qtd = conf.getQuantidadeResultados();

            for (i = 0; i < qtd;  i++)
            {
                containerResultados.RowCount++;
                containerResultados.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                containerResultados.Controls.Add(new Label() { Text = "Teste" + i, Anchor = AnchorStyles.Left, AutoSize = true }, 0, containerResultados.RowCount-1);
            }

            panelBuscarCurriculos.Visible = false;
            panelHistoricoBuscas.Visible = false;
            panelConfiguracoes.Visible = false;
            panelResultados.Visible = true;
        }

    }
}
