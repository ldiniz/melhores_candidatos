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

        private TextBox getTextBoxSalario()
        {
            TextBox textBox = new TextBox();
            textBox.Anchor = ((AnchorStyles)((AnchorStyles.Left | AnchorStyles.Right)));
            textBox.Location = new Point(430, 58);
            textBox.Size = new Size(246, 33);
            textBox.TabIndex = 35;

            return textBox;
        }

        private Label getLabelSalario()
        {
            Label label = new Label();
            label.Anchor = AnchorStyles.Left;
            label.AutoSize = true;
            label.Location = new Point(338, 62);
            label.Size = new Size(86, 25);
            label.TabIndex = 34;
            label.Text = "Salário";

            return label;
        }

        private ComboBox getComboBoxNivelCargo()
        {
            ComboBox newComboBox = new ComboBox();
            newComboBox.Anchor = ((AnchorStyles)((AnchorStyles.Left | AnchorStyles.Right)));
            newComboBox.FormattingEnabled = true;
            newComboBox.Location = new Point(430, 8);
            newComboBox.Size = new Size(246, 33);
            newComboBox.TabIndex = 31;

            return newComboBox;
        }

        private TextBox getTextBoxExperiencia()
        {
            TextBox textBox = new TextBox();
            textBox.Anchor = ((AnchorStyles)((AnchorStyles.Left | AnchorStyles.Right)));
            textBox.Location = new Point(143, 58);
            textBox.Size = new Size(189, 33);
            textBox.TabIndex = 33;

            return textBox;
        }

        private Label getLabelNivelCargo()
        {
            Label label = new Label();
            label.Anchor = AnchorStyles.Left;
            label.AutoSize = true;
            label.Location = new Point(338, 12);
            label.Size = new Size(65, 25);
            label.TabIndex = 29;
            label.Text = "Nível";

            return label;
        }

        private Label getLabelExperiencia()
        {
            Label label = new Label();
            label.Anchor = AnchorStyles.Left;
            label.AutoSize = true;
            label.Location = new Point(3, 62);
            label.Size = new Size(134, 25);
            label.TabIndex = 32;
            label.Text = "Experiência";

            return label;
        }

        private TextBox getTextBoxCargo()
        {
            TextBox textBox = new TextBox();
            textBox.Anchor = ((AnchorStyles)((AnchorStyles.Left | AnchorStyles.Right)));
            textBox.Location = new Point(143, 8);
            textBox.Size = new Size(189, 33);
            textBox.TabIndex = 30;

            return textBox;
        }

        private Label getLabelCargo()
        {
            Label label = new Label();
            label.Anchor = AnchorStyles.Left;
            label.AutoSize = true;
            label.Location = new Point(3, 12);
            label.Size = new Size(75, 25);
            label.TabIndex = 28;
            label.Text = "Cargo";
            label.TextAlign = ContentAlignment.MiddleCenter;

            return label; 
        }

        private TableLayoutPanel addCargo()
        {
            TableLayoutPanel newCargo = new TableLayoutPanel();
            newCargo.ColumnCount = 5;
            newCargo.ColumnStyles.Add(new ColumnStyle());
            newCargo.ColumnStyles.Add(new ColumnStyle());
            newCargo.ColumnStyles.Add(new ColumnStyle());
            newCargo.ColumnStyles.Add(new ColumnStyle());
            newCargo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 252F));
            newCargo.Controls.Add(this.getTextBoxSalario(), 4, 1);
            newCargo.Controls.Add(this.getLabelSalario(), 3, 1);
            newCargo.Controls.Add(this.getComboBoxNivelCargo(), 4, 0);
            newCargo.Controls.Add(this.getTextBoxExperiencia(), 2, 1);
            newCargo.Controls.Add(this.getLabelNivelCargo(), 3, 0);
            newCargo.Controls.Add(this.getLabelExperiencia(), 1, 1);
            newCargo.Controls.Add(this.getTextBoxCargo(), 2, 0);
            newCargo.Controls.Add(this.getLabelCargo(), 1, 0);
            newCargo.Location = new Point(42, 3);
            newCargo.RowCount = 2;
            newCargo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            newCargo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            newCargo.Size = new Size(679, 100);
            newCargo.TabIndex = 40;

            return newCargo;
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
            containerCargo.RowCount++;
            containerCargo.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            containerCargo.Controls.Add(this.addCargo(), 1, containerCargo.RowCount - 1); //coluna, linha
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
