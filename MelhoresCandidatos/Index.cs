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
        public Index()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelBuscarCurriculos.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            containerCargo.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            containerCargo.RowCount++;
            Button b = new Button();
            b.Text = "teste";
            containerCargo.Controls.Add(b, 0, 1); //coluna, linha
        }

    }
}
