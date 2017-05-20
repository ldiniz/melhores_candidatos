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

        // 
        // Buttons
        // 
        private Button buttonPlusCargo()
        {
            Button newButton = new Button();
            newButton.Location = new Point(3, 3);
            newButton.Size = new Size(33, 42);
            newButton.TabIndex = 41;
            newButton.Text = "+";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += new EventHandler(this.plusAddCargo);

            return newButton;
        }

        private Button buttonPlusDeficiencia()
        {
            Button newButton = new Button();
            newButton.Location = new Point(3, 3);
            newButton.Size = new Size(33, 42);
            newButton.TabIndex = 41;
            newButton.Text = "+";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += new EventHandler(this.plusAddDeficiencia);

            return newButton;
        }

        private Button buttonPlusEndereco()
        {
            Button newButton = new Button();
            newButton.Location = new Point(3, 3);
            newButton.Size = new Size(33, 42);
            newButton.TabIndex = 41;
            newButton.Text = "+";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += new EventHandler(this.plusAddEndereco);

            return newButton;
        }

        private Button buttonBuscarCurriculos()
        {
            Button newButton = new Button();
            newButton.Cursor = Cursors.Hand;
            newButton.FlatStyle = FlatStyle.Flat;
            newButton.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            newButton.ForeColor = SystemColors.GrayText;
            newButton.Location = new Point(3, 3);
            newButton.Size = new Size(194, 60);
            newButton.TabIndex = 0;
            newButton.Text = "Buscar Currículos";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += new EventHandler(this.buscarCurriculosClick);

            return newButton;
        }

        private Button buttonHistoricoDeBuscas()
        {
            Button newButton = new Button();
            newButton.Cursor = Cursors.Hand;
            newButton.FlatStyle = FlatStyle.Flat;
            newButton.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            newButton.ForeColor = SystemColors.GrayText;
            newButton.Location = new Point(24, 69);
            newButton.Size = new Size(194, 60);
            newButton.TabIndex = 1;
            newButton.Text = "Histórico de Buscas";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += new EventHandler(this.historicoDeBuscasClick);

            return newButton;
        }

        private Button buttonAgendaDeEntrevistas()
        {
            Button newButton = new Button();
            newButton.Cursor = Cursors.Hand;
            newButton.FlatStyle = FlatStyle.Flat;
            newButton.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            newButton.ForeColor = SystemColors.GrayText;
            newButton.Location = new Point(3, 135);
            newButton.Size = new Size(194, 60);
            newButton.TabIndex = 2;
            newButton.Text = "Agenda de Entrevistas";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += new EventHandler(this.agendaDeEntrevistasClick);

            return newButton;
        }

        private Button buttonConfiguracoes()
        {
            Button newButton = new Button();
            newButton.Cursor = Cursors.Hand;
            newButton.FlatStyle = FlatStyle.Flat;
            newButton.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            newButton.ForeColor = SystemColors.GrayText;
            newButton.Location = new Point(770, 534);
            newButton.Size = new Size(188, 44);
            newButton.TabIndex = 5;
            newButton.Text = "Configurações";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += new EventHandler(this.configuracoesClick);

            return newButton;
        }

        private Button buttonBuscar()
        {
            Button newButton = new Button();
            newButton.Cursor = Cursors.Hand;
            newButton.Location = new Point(862, 24);
            newButton.Size = new Size(114, 37);
            newButton.TabIndex = 5;
            newButton.Text = "Buscar";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += new EventHandler(this.buttonBuscarCurriculosClick);

            return newButton;
        }
        
        private Button buttonVoltar()
        {
            Button newButton = new Button();
            newButton.Cursor = Cursors.Hand;
            newButton.Location = new Point(719, 24);
            newButton.Size = new Size(114, 37);
            newButton.TabIndex = 18;
            newButton.Text = "Voltar";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += new EventHandler(this.buttonVoltarClick);

            return newButton;
        }

        // 
        // TextBox
        // 
        private TextBox getTextBoxSalario()
        {
            TextBox textBox = new TextBox();
            textBox.Anchor = ((AnchorStyles)((AnchorStyles.Left | AnchorStyles.Right)));
            textBox.Location = new Point(430, 58);
            textBox.Size = new Size(246, 33);
            textBox.TabIndex = 35;

            return textBox;
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

        private TextBox getTextBoxCargo()
        {
            TextBox textBox = new TextBox();
            textBox.Anchor = ((AnchorStyles)((AnchorStyles.Left | AnchorStyles.Right)));
            textBox.Location = new Point(143, 8);
            textBox.Size = new Size(189, 33);
            textBox.TabIndex = 30;

            return textBox;
        }

        private TextBox getTextBox1()
        {
            TextBox newTextBox = new TextBox();
            newTextBox.Location = new Point(281, 85);
            newTextBox.Size = new Size(128, 33);
            newTextBox.TabIndex = 4;

            return newTextBox;
        }

        private TextBox getTextBox3()
        {
            TextBox newTextBox = new TextBox();
            newTextBox.Location = new Point(289, 168);
            newTextBox.Size = new Size(80, 33);
            newTextBox.TabIndex = 16;

            return newTextBox;
        }
        
        private TextBox getTextBox2()
        {
            TextBox newTextBox = new TextBox();
            newTextBox.Location = new Point(180, 168);
            newTextBox.Size = new Size(72, 33);
            newTextBox.TabIndex = 15;

            return newTextBox;
        }

        // 
        // Labels
        // 
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

        private Label getLabelBairro()
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Location = new Point(766, 297);
            label.Size = new Size(76, 25);
            label.TabIndex = 27;
            label.Text = "Bairro";

            return label;
        }

        private Label getLabelCidade()
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Location = new Point(430, 297);
            label.Size = new Size(85, 25);
            label.TabIndex = 24;
            label.Text = "Cidade";

            return label;
        }

        private Label getLabelDeficiencia()
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Location = new Point(25, 350);
            label.Size = new Size(127, 25);
            label.TabIndex = 19;
            label.Text = "Deficiência";

            return label;
        }

        private Label getLabelEstado()
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Location = new Point(25, 297);
            label.Size = new Size(83, 25);
            label.TabIndex = 21;
            label.Text = "Estado";

            return label;
        }

        private Label getLabelA()
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Location = new Point(258, 171);
            label.Size = new Size(25, 25);
            label.TabIndex = 17;
            label.Text = "a";

            return label;
        }

        private Label getLabelEstadoCivil()
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Location = new Point(25, 215);
            label.Size = new Size(135, 25);
            label.TabIndex = 11;
            label.Text = "Estado Civil";

            return label;
        }

        private Label getLabelIdade()
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Location = new Point(25, 171);
            label.Size = new Size(72, 25);
            label.TabIndex = 10;
            label.Text = "Idade";

            return label;
        }

        private Label getLabelCNH()
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Location = new Point(430, 135);
            label.Size = new Size(59, 25);
            label.TabIndex = 9;
            label.Text = "CNH";

            return label;
        }

        private Label getLabelSexo()
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Location = new Point(25, 131);
            label.Size = new Size(64, 25);
            label.TabIndex = 6;
            label.Text = "Sexo";

            return label;
        }

        private Label getLabelVagas()
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Location = new Point(25, 86);
            label.Size = new Size(199, 25);
            label.TabIndex = 3;
            label.Text = "Número de Vagas";

            return label;
        }

        private Label getLabelBuscarCurriculos()
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            label.Location = new Point(24, 24);
            label.Size = new Size(280, 32);
            label.TabIndex = 2;
            label.Text = "Buscar Currículos";

            return label;
        }

        private Label getLabelNome()
        {
            Label label = new Label();
            label.Anchor = AnchorStyles.Left;
            label.AutoSize = true;
            label.ImageAlign = ContentAlignment.MiddleLeft;
            label.Location = new Point(4, 15);
            label.Size = new Size(74, 25);
            label.TabIndex = 0;
            label.Text = "Nome";
            label.TextAlign = ContentAlignment.MiddleLeft;

            return label;
        }
        //Label label = new Label();
        //label5.Anchor = AnchorStyles.Left;
        //label5.AutoSize = true;
        //label5.Location = new Point(85, 15);
        //label5.Name = "label15";
        //label5.Size = new Size(72, 25);
        //label5.TabIndex = 1;
        //label5.Text = "Idade";

        private Label getLabelEscolaridade()
        {
            Label label = new Label();
            label.Anchor = AnchorStyles.Left;
            label.AutoSize = true;
            label.Location = new Point(164, 15);
            label.Size = new Size(146, 25);
            label.TabIndex = 2;
            label.Text = "Escolaridade";

            return label;
        }

        private Label getLabelPretensao()
        {
            Label label = new Label();
            label.Anchor = AnchorStyles.Left;
            label.AutoSize = true;
            label.Location = new Point(317, 15);
            label.Size = new Size(118, 25);
            label.TabIndex = 3;
            label.Text = "Pretensão";

            return label;
        }


        //Label label = new Label();
        //this.label22.Anchor =AnchorStyles.Left;
        //this.label22.AutoSize = true;
        //this.label22.Location = new Point(442, 15);
        //this.label22.Name = "label22";
        //this.label22.Size = new Size(83, 25);
        //this.label22.TabIndex = 4;
        //this.label22.Text = "Estado";

        //Label label = new Label();
        //this.label23.Anchor =AnchorStyles.Left;
        //this.label23.AutoSize = true;
        //this.label23.Location = new Point(532, 15);
        //this.label23.Name = "label23";
        //this.label23.Size = new Size(85, 25);
        //this.label23.TabIndex = 5;
        //this.label23.Text = "Cidade";

        private Label getLabelCurriculo()
        {
            Label label = new Label();
            label.Anchor =AnchorStyles.Left;
            label.AutoSize = true;
            label.Location = new Point(624, 15);
            label.Size = new Size(107, 25);
            label.TabIndex = 6;
            label.Text = "Currículo";

            return label;
        }

        private Label getLabelEntrevista()
        {
            Label label = new Label();
            label.Anchor =AnchorStyles.Left;
            label.AutoSize = true;
            label.Location = new Point(738, 15);
            label.Size = new Size(118, 25);
            label.TabIndex = 7;
            label.Text = "Entrevista";

            return label;
        }

        private Label getLabelResultados()
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            label.Location = new Point(54, 42);
            label.Size = new Size(182, 32);
            label.TabIndex = 0;
            label.Text = "Resultados";

            return label;
        }

        private Label getLabelConfig()
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            label.Location = new Point(24, 24);
            label.Size = new Size(312, 32);
            label.TabIndex = 0;
            label.Text = "Configurações";

            return label;
        }

        private Label getLabelHistoricoBuscas()
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            label.Location = new Point(24, 24);
            label.Size = new Size(312, 32);
            label.TabIndex = 0;
            label.Text = "Histórico de Buscas";

            return label;
        }

        private Label getLabelMelhoresCandidatos()
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Font = new Font("Segoe Print", 26.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            label.Location = new Point(340, 61);
            label.Size = new Size(389, 62);
            label.TabIndex = 2;
            label.Text = "Melhores Candidatos";

            return label;
        }

        private Label getLabelAgendaEntrevistas()
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            label.Location = new Point(24, 24);
            label.Size = new Size(312, 32);
            label.TabIndex = 0;
            label.Text = "Agenda de Entrevistas";

            return label;
        }

        // 
        // ComboBox
        // 

        private ComboBox getComboBoxBairro()
        {
            ComboBox newComboBox = new ComboBox();
            newComboBox.Location = new Point(848, 294);
            newComboBox.Size = new Size(188, 33);
            newComboBox.Items.AddRange(new object[] {
            "Eldorado",});
            newComboBox.TabIndex = 26;

            return newComboBox;
        }

        private ComboBox getComboBoxCidade()
        {
            ComboBox newComboBox = new ComboBox();
            newComboBox.Location = new Point(521, 294);
            newComboBox.Size = new Size(188, 33);
            newComboBox.Items.AddRange(new object[] {
            "Contagem",});
            newComboBox.TabIndex = 25;

            return newComboBox;
        }

        private ComboBox getComboBoxEstado()
        {
            ComboBox newComboBox = new ComboBox();
            newComboBox.Location = new Point(180, 294);
            newComboBox.Size = new Size(189, 33);
            newComboBox.Items.AddRange(new object[] {
            "MG",});
            newComboBox.TabIndex = 23;

            return newComboBox;
        }

        private ComboBox getComboBoxNivelCargo()
        {
            ComboBox newComboBox = new ComboBox();
            newComboBox.Anchor = ((AnchorStyles)((AnchorStyles.Left | AnchorStyles.Right)));
            newComboBox.FormattingEnabled = true;
            newComboBox.Location = new Point(430, 58);
            newComboBox.Size = new Size(246, 33);
            newComboBox.TabIndex = 31;

            return newComboBox;
        }

        private ComboBox getComboBoxDeficiencia()
        {
            ComboBox newComboBox = new ComboBox();
            newComboBox.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            newComboBox.FormattingEnabled = true;
            newComboBox.Location = new Point(180, 254);
            newComboBox.Size = new Size(189, 31);
            newComboBox.TabIndex = 20;

            return newComboBox;
        }

        private ComboBox getComboBoxEstadoCivil()
        {
            ComboBox newComboBox = new ComboBox();
            newComboBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            newComboBox.FormattingEnabled = true;
            newComboBox.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Divorciado",
            "Viúvo"});
            newComboBox.Location = new System.Drawing.Point(180, 212);
            newComboBox.Size = new System.Drawing.Size(189, 31);
            newComboBox.TabIndex = 12;

            return newComboBox;
        }
        
        private ComboBox getComboBoxCNH()
        {
            ComboBox newComboBox = new ComboBox();
            newComboBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            newComboBox.FormattingEnabled = true;
            newComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            newComboBox.Location = new System.Drawing.Point(517, 129);
            newComboBox.Size = new System.Drawing.Size(188, 31);
            newComboBox.TabIndex = 8;

            return newComboBox;
        }
        
        private ComboBox getComboBoxSexo()
        {
            ComboBox newComboBox = new ComboBox();
            newComboBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            newComboBox.FormattingEnabled = true;
            newComboBox.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            newComboBox.Location = new System.Drawing.Point(180, 129);
            newComboBox.Size = new System.Drawing.Size(189, 31);
            newComboBox.TabIndex = 7;

            return newComboBox;
        }

        // 
        // CheckBox
        //
        private CheckBox checkBoxDesempregado()
        {
            CheckBox newCheckBox = new CheckBox();
            newCheckBox.AutoSize = true;
            newCheckBox.Location = new System.Drawing.Point(435, 197);
            newCheckBox.Size = new System.Drawing.Size(191, 29);
            newCheckBox.TabIndex = 14;
            newCheckBox.Text = "Desempregado";
            newCheckBox.UseVisualStyleBackColor = true;

            return newCheckBox;
        }

        private CheckBox checkBoxDisponibilidadeViagem()
        {
            CheckBox newCheckBox = new CheckBox();
            newCheckBox.AutoSize = true;
            newCheckBox.Location = new System.Drawing.Point(435, 231);
            newCheckBox.Size = new System.Drawing.Size(335, 29);
            newCheckBox.TabIndex = 13;
            newCheckBox.Text = "Disponibilidade para viagens";
            newCheckBox.UseVisualStyleBackColor = true;

            return newCheckBox;
        }

        // 
        // TableLayout
        // 
        private TableLayoutPanel addCargo()
        {
            TableLayoutPanel newCargo = new TableLayoutPanel();
            newCargo.ColumnCount = 5;
            newCargo.ColumnStyles.Add(new ColumnStyle());
            newCargo.ColumnStyles.Add(new ColumnStyle());
            newCargo.ColumnStyles.Add(new ColumnStyle());
            newCargo.ColumnStyles.Add(new ColumnStyle());
            newCargo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
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
            newCargo.Size = new Size(650, 100);
            newCargo.TabIndex = 40;

            return newCargo;
        }

        private TableLayoutPanel addDeficiencia()
        {
            TableLayoutPanel newDeficiencia = new TableLayoutPanel();
            newDeficiencia.ColumnCount = 3;
            newDeficiencia.ColumnStyles.Add(new ColumnStyle());
            newDeficiencia.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            newDeficiencia.Controls.Add(this.getComboBoxDeficiencia(), 2, 0);
            newDeficiencia.Controls.Add(this.getLabelDeficiencia(), 1, 0);
            newDeficiencia.Location = new Point(20, 3);
            newDeficiencia.RowCount = 1;
            newDeficiencia.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            newDeficiencia.Size = new Size(500, 100);
            newDeficiencia.TabIndex = 40;

            return newDeficiencia;
        }

        private TableLayoutPanel addEndereco()
        {
            TableLayoutPanel newEndereco = new TableLayoutPanel();
            newEndereco.ColumnCount = 7;
            newEndereco.ColumnStyles.Add(new ColumnStyle());
            newEndereco.ColumnStyles.Add(new ColumnStyle());
            newEndereco.ColumnStyles.Add(new ColumnStyle());
            newEndereco.ColumnStyles.Add(new ColumnStyle());
            newEndereco.ColumnStyles.Add(new ColumnStyle());
            newEndereco.ColumnStyles.Add(new ColumnStyle());
            newEndereco.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            newEndereco.Controls.Add(this.getComboBoxBairro(), 6, 0);
            newEndereco.Controls.Add(this.getLabelBairro(), 5, 0);
            newEndereco.Controls.Add(this.getComboBoxCidade(), 4, 0);
            newEndereco.Controls.Add(this.getLabelCidade(), 3, 0);
            newEndereco.Controls.Add(this.getComboBoxEstado(), 2, 0);
            newEndereco.Controls.Add(this.getLabelEstado(), 1, 0);
            newEndereco.Location = new Point(20, 3);
            newEndereco.RowCount = 1;
            newEndereco.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            newEndereco.Size = new Size(900, 100);
            newEndereco.TabIndex = 40;

            return newEndereco;
        }

        // 
        // Events
        // 
        private void buscarCurriculosClick(object sender, EventArgs e)
        {
            panelBuscarCurriculos.Visible = true;
            panelResultados.Visible = false;
            panelHistoricoBuscas.Visible = false;
            panelAgendaEntrevistas.Visible = false;
            panelConfiguracoes.Visible = false;
        }

        private void historicoDeBuscasClick(object sender, EventArgs e)
        {
            panelBuscarCurriculos.Visible = false;
            panelResultados.Visible = false;
            panelHistoricoBuscas.Visible = true;
            panelAgendaEntrevistas.Visible = false;
            panelConfiguracoes.Visible = false;
        }

        private void agendaDeEntrevistasClick(object sender, EventArgs e)
        {
            panelBuscarCurriculos.Visible = false;
            panelResultados.Visible = false;
            panelHistoricoBuscas.Visible = false;
            panelConfiguracoes.Visible = false;
            panelAgendaEntrevistas.Visible = true;
        }

        private void configuracoesClick(object sender, EventArgs e)
        {
            panelBuscarCurriculos.Visible = false;
            panelResultados.Visible = false;
            panelHistoricoBuscas.Visible = false;
            panelAgendaEntrevistas.Visible = false;
            panelConfiguracoes.Visible = true;
        }

        private void buttonVoltarClick(object sender, EventArgs e)
        {
            panelBuscarCurriculos.Visible = false;
            panelResultados.Visible = false;
            panelHistoricoBuscas.Visible = false;
            panelAgendaEntrevistas.Visible = false;
            panelConfiguracoes.Visible = false;
        }

        private void plusAddCargo(object sender, EventArgs e)
        {
            containerCargo.RowCount++;
            containerCargo.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            containerCargo.Controls.Add(this.addCargo(), 1, containerCargo.RowCount - 1); //coluna, linha
        }

        private void plusAddDeficiencia(object sender, EventArgs e)
        {
            containerDeficiencia.RowCount++;
            containerDeficiencia.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            containerDeficiencia.Controls.Add(this.addDeficiencia(), 1, containerDeficiencia.RowCount - 1); //coluna, linha
        }

        private void plusAddEndereco(object sender, EventArgs e)
        {
            containerEndereco.RowCount++;
            containerEndereco.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            int insertedRowNum = containerEndereco.RowCount - 1;
            containerEndereco.Controls.Add(this.addEndereco(), 1, insertedRowNum); //coluna, linha

            //panelBuscarCurriculos.Visible = false;
            //foreach (Control ExistControl in panelBuscarCurriculos.Controls)
            //{
            //    if (panelBuscarCurriculos.GetRow(ExistControl) >= insertedRowNum)
            //    {
            //        panelBuscarCurriculos.SetRow(ExistControl,
            //                                panelBuscarCurriculos.GetRow(ExistControl) + 1);
            //    }
            //}
            //panelBuscarCurriculos.Visible = true;
        }

        private void buttonBuscarCurriculosClick(object sender, EventArgs e)
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
            panelAgendaEntrevistas.Visible = false;
            panelResultados.Visible = true;
        }

    }
}
