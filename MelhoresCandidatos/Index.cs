using MongoDB.Bson;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MelhoresCandidatos
{
    public partial class Index : Form
    {
        Configuracoes conf;
        public MongoDBClient mongo;

        //Informações Iniciais
        ArrayList NrVagas = new ArrayList();
        ArrayList isMandatoryNrVagas = new ArrayList();
        ArrayList Sexo = new ArrayList();
        ArrayList isMandatorySexo = new ArrayList();
        ArrayList CNH = new ArrayList();
        ArrayList isMandatoryCNH = new ArrayList();
        ArrayList Idade = new ArrayList();
        ArrayList isMandatoryIdade = new ArrayList();
        ArrayList EstadoCivil = new ArrayList();
        ArrayList isMandatoryEstadoCivil = new ArrayList();
        CheckBox Desempregado;
        CheckBox DisponibilidadeViagens;

        //Deficiência
        ArrayList Deficiencia = new ArrayList();
        ArrayList isMandatoryDeficiencia = new ArrayList();

        //Localização
        ArrayList Estado = new ArrayList();
        ArrayList isMandatoryEstado = new ArrayList();
        ArrayList Cidade = new ArrayList();
        ArrayList isMandatoryCidade = new ArrayList();
        ArrayList Bairro = new ArrayList();
        ArrayList isMandatoryBairro = new ArrayList();

        //Experiência
        ArrayList Cargo = new ArrayList();
        ArrayList isMandatoryCargo = new ArrayList();
        ArrayList NivelCargo = new ArrayList();
        ArrayList isMandatoryNivelCargo = new ArrayList();
        ArrayList Experiencia = new ArrayList();
        ArrayList isMandatoryExperiencia = new ArrayList();
        ArrayList Salario = new ArrayList();
        ArrayList isMandatorySalario = new ArrayList();

        //Línguas
        ArrayList Idioma = new ArrayList();
        ArrayList isMandatoryIdioma = new ArrayList();
        ArrayList NivelIdioma = new ArrayList();
        ArrayList isMandatoryNivelIdioma = new ArrayList();

        //Escolaridade
        ArrayList Grau = new ArrayList();
        ArrayList isMandatoryGrau = new ArrayList();
        ArrayList Incompleto = new ArrayList();
        ArrayList Curso = new ArrayList();
        ArrayList isMandatoryCurso = new ArrayList();
        ArrayList Instituicao = new ArrayList();
        ArrayList isMandatoryInstituicao = new ArrayList();
        ArrayList InicioEscolaridade = new ArrayList();
        ArrayList isMandatoryInicioEscolaridade = new ArrayList();
        ArrayList FimEscolaridade = new ArrayList();
        ArrayList isMandatoryFimEscolaridade = new ArrayList();

        //Competências
        ArrayList Area = new ArrayList();
        ArrayList isMandatoryArea = new ArrayList();
        ArrayList Competencias1 = new ArrayList();
        ArrayList Competencias2 = new ArrayList();
        ArrayList Competencias3 = new ArrayList();
        ArrayList isMandatoryCompetencia = new ArrayList();

        public Index()
        {
            mongo = new MongoDBClient();
            InitializeComponent();
            conf = new Configuracoes();
        }

        private PictureBox getImage()
        {
            PictureBox pb = new PictureBox();
            pb.ImageLocation = "../../image/image.png";
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            pb.Location = new Point(30, 40);

            return pb;
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

        private Button buttonPlusIdioma()
        {
            Button newButton = new Button();
            newButton.Location = new Point(3, 3);
            newButton.Size = new Size(33, 42);
            newButton.TabIndex = 41;
            newButton.Text = "+";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += new EventHandler(this.plusAddIdioma);

            return newButton;
        }

        private Button buttonPlusEscolaridade()
        {
            Button newButton = new Button();
            newButton.Location = new Point(3, 3);
            newButton.Size = new Size(33, 42);
            newButton.TabIndex = 41;
            newButton.Text = "+";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += new EventHandler(this.plusAddEscolaridade);

            return newButton;
        }

        private Button buttonPlusCompetencia()
        {
            Button newButton = new Button();
            newButton.Location = new Point(3, 3);
            newButton.Size = new Size(33, 42);
            newButton.TabIndex = 41;
            newButton.Text = "+";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += new EventHandler(this.plusAddCompetencia);

            return newButton;
        }

        private Button buttonPlusDeficiencia()
        {
            Button newButton = new Button();
            newButton.Location = new Point(3, 3);
            newButton.Size = new Size(33, 60);
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
            newButton.Font = new Font("Verdana", 16F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            newButton.ForeColor = Color.Black;
            newButton.Location = new Point(3, 3);
            newButton.Size = new Size(250, 75);
            newButton.TabIndex = 0;
            newButton.Text = "Buscar Currículos";
            newButton.BackColor = Color.RoyalBlue;
            newButton.Click += new EventHandler(this.buscarCurriculosClick);

            return newButton;
        }

        private Button buttonHistoricoDeBuscas()
        {
            Button newButton = new Button();
            newButton.Cursor = Cursors.Hand;
            newButton.FlatStyle = FlatStyle.Flat;
            newButton.Font = new Font("Verdana", 16F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            newButton.ForeColor = Color.Black;
            newButton.Location = new Point(24, 69);
            newButton.Size = new Size(250, 75);
            newButton.TabIndex = 1;
            newButton.Text = "Histórico de Buscas";
            newButton.BackColor = Color.RoyalBlue;
            newButton.Click += new EventHandler(this.historicoDeBuscasClick);

            return newButton;
        }

        private Button buttonAgendaDeEntrevistas()
        {
            Button newButton = new Button();
            newButton.Cursor = Cursors.Hand;
            newButton.FlatStyle = FlatStyle.Flat;
            newButton.Font = new Font("Verdana", 16F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            newButton.ForeColor = Color.Black;
            newButton.Location = new Point(3, 135);
            newButton.Size = new Size(250, 75);
            newButton.TabIndex = 2;
            newButton.Text = "Agenda de Entrevistas";
            newButton.BackColor = Color.RoyalBlue;
            newButton.Click += new EventHandler(this.agendaDeEntrevistasClick);

            return newButton;
        }

        private Button buttonConfiguracoes()
        {
            Button newButton = new Button();
            newButton.Cursor = Cursors.Hand;
            newButton.FlatStyle = FlatStyle.Flat;
            newButton.Font = new Font("Verdana", 16F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            newButton.ForeColor = Color.Black;
            newButton.Location = new Point(770, 534);
            newButton.Size = new Size(225, 60);
            newButton.TabIndex = 5;
            newButton.Text = "Configurações";
            newButton.BackColor = Color.Gray;
            newButton.Click += new EventHandler(this.configuracoesClick);

            return newButton;
        }

        private Button buttonBuscar()
        {
            Button newButton = new Button();
            newButton.Cursor = Cursors.Hand;
            newButton.FlatStyle = FlatStyle.Flat;
            newButton.Location = new Point(1000, 24);
            newButton.Size = new Size(120,45);
            newButton.TabIndex = 5;
            newButton.Text = "Buscar";
            newButton.BackColor = Color.Gray;
            newButton.Click += new EventHandler(this.buttonBuscarCurriculosClick);

            return newButton;
        }

        private Button buttonVoltar()
        {
            Button newButton = new Button();
            newButton.Cursor = Cursors.Hand;
            newButton.FlatStyle = FlatStyle.Flat;
            newButton.Location = new Point(1000, 24);
            newButton.Size = new Size(120, 45);
            newButton.TabIndex = 18;
            newButton.Text = "Voltar";
            newButton.BackColor = Color.Gray;
            newButton.Click += new EventHandler(this.buttonVoltarClick);

            return newButton;
        }

        private Button buttonVoltar1()
        {
            Button newButton = new Button();
            newButton.Cursor = Cursors.Hand;
            newButton.FlatStyle = FlatStyle.Flat;
            newButton.Location = new Point(850, 24);
            newButton.Size = new Size(120, 45);
            newButton.TabIndex = 18;
            newButton.Text = "Voltar";
            newButton.BackColor = Color.Gray;
            newButton.Click += new EventHandler(this.buttonVoltarClick);

            return newButton;
        }

        private Button buttonVoltar2()
        {
            Button newButton = new Button();
            newButton.Cursor = Cursors.Hand;
            newButton.FlatStyle = FlatStyle.Flat;
            newButton.Location = new Point(850, 24);
            newButton.Size = new Size(120, 45);
            newButton.TabIndex = 18;
            newButton.Text = "Voltar";
            newButton.BackColor = Color.Gray;
            newButton.Click += new EventHandler(this.buttonVoltarClick2);

            return newButton;
        }

        private Button buttonVoltar3()
        {
            Button newButton = new Button();
            newButton.Cursor = Cursors.Hand;
            newButton.FlatStyle = FlatStyle.Flat;
            newButton.Location = new Point(850, 24);
            newButton.Size = new Size(120, 45);
            newButton.TabIndex = 18;
            newButton.Text = "Voltar";
            newButton.BackColor = Color.Gray;
            newButton.Click += new EventHandler(this.buttonVoltarClick3);

            return newButton;
        }

        private Button buttonProximo()
        {
            Button newButton = new Button();
            newButton.Cursor = Cursors.Hand;
            newButton.FlatStyle = FlatStyle.Flat;
            newButton.Location = new Point(1000, 24);
            newButton.Size = new Size(120, 45);
            newButton.TabIndex = 18;
            newButton.Text = "Próximo";
            newButton.BackColor = Color.Gray;
            newButton.Click += new EventHandler(this.buttonProximoClick);

            return newButton;
        }

        private Button buttonProximo2()
        {
            Button newButton = new Button();
            newButton.Cursor = Cursors.Hand;
            newButton.FlatStyle = FlatStyle.Flat;
            newButton.Location = new Point(1000, 24);
            newButton.Size = new Size(120,45);
            newButton.TabIndex = 18;
            newButton.Text = "Próximo";
            newButton.BackColor = Color.Gray;
            newButton.Click += new EventHandler(this.buttonProximoClick2);

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
            textBox.Size = new Size(200, 33);
            textBox.TabIndex = 35;
            textBox.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            Salario.Add(textBox);

            return textBox;
        }

        private TextBox getTextBoxIdioma()
        {
            TextBox textBox = new TextBox();
            textBox.Anchor = ((AnchorStyles)((AnchorStyles.Left | AnchorStyles.Right)));
            textBox.Location = new Point(120, 5);
            textBox.Size = new Size(100, 25);
            textBox.TabIndex = 35;
            textBox.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            Idioma.Add(textBox);

            return textBox;
        }

        private TextBox getTextBoxExperiencia()
        {
            TextBox textBox = new TextBox();
            textBox.Anchor = ((AnchorStyles)((AnchorStyles.Left | AnchorStyles.Right)));
            textBox.Location = new Point(143, 58);
            textBox.Size = new Size(189, 33);
            textBox.TabIndex = 33;
            textBox.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            Experiencia.Add(textBox);

            return textBox;
        }

        private TextBox getTextBoxCurso()
        {
            TextBox textBox = new TextBox();
            textBox.Anchor = ((AnchorStyles)((AnchorStyles.Left | AnchorStyles.Right)));
            textBox.Location = new Point(143, 8);
            textBox.Size = new Size(189, 33);
            textBox.TabIndex = 30;
            textBox.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            Curso.Add(textBox);

            return textBox;
        }

        private TextBox getTextBoxInstituicao()
        {
            TextBox textBox = new TextBox();
            textBox.Anchor = ((AnchorStyles)((AnchorStyles.Left | AnchorStyles.Right)));
            textBox.Location = new Point(143, 8);
            textBox.Size = new Size(189, 33);
            textBox.TabIndex = 30;
            textBox.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            Instituicao.Add(textBox);

            return textBox;
        }

        private TextBox getTextBoxInicio()
        {
            TextBox textBox = new TextBox();
            textBox.Anchor = ((AnchorStyles)((AnchorStyles.Left | AnchorStyles.Right)));
            textBox.Location = new Point(143, 8);
            textBox.Size = new Size(189, 33);
            textBox.TabIndex = 30;
            textBox.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            InicioEscolaridade.Add(textBox);

            return textBox;
        }

        private TextBox getTextBoxConclusao()
        {
            TextBox textBox = new TextBox();
            textBox.Anchor = ((AnchorStyles)((AnchorStyles.Left | AnchorStyles.Right)));
            textBox.Location = new Point(143, 8);
            textBox.Size = new Size(189, 33);
            textBox.TabIndex = 30;
            textBox.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            FimEscolaridade.Add(textBox);

            return textBox;
        }

        private TextBox getTextBoxVagas()
        {
            TextBox newTextBox = new TextBox();
            newTextBox.Location = new Point(281, 100);
            newTextBox.Size = new Size(200, 33);
            newTextBox.TabIndex = 4;
            newTextBox.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            NrVagas.Add(newTextBox);

            return newTextBox;
        }

        private TextBox getTextBoxFimIdade()
        {
            TextBox newTextBox = new TextBox();
            newTextBox.Location = new Point(310, 225);
            newTextBox.Size = new Size(80, 33);
            newTextBox.TabIndex = 16;
            newTextBox.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            Idade.Add(newTextBox);

            return newTextBox;
        }
        
        private TextBox getTextBoxInicioIdade()
        {
            TextBox newTextBox = new TextBox();
            newTextBox.Location = new Point(190, 225);
            newTextBox.Size = new Size(80, 33);
            newTextBox.TabIndex = 15;
            newTextBox.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            Idade.Add(newTextBox);

            return newTextBox;
        }

        // 
        // Labels
        // 
        private CheckBox getLabelSalario()
        {
            CheckBox newCheckBox = new CheckBox();
            newCheckBox.AutoSize = true;
            newCheckBox.Location = new Point(338, 62);
            newCheckBox.Size = new Size(86, 25);
            newCheckBox.TabIndex = 3;
            newCheckBox.Text = "Salário";
            newCheckBox.UseVisualStyleBackColor = true;
            isMandatorySalario.Add(newCheckBox);

            return newCheckBox;
        }

        private CheckBox getLabelCargo()
        {
            CheckBox newCheckBox = new CheckBox();
            newCheckBox.AutoSize = true;
            newCheckBox.Location = new Point(3, 12);
            newCheckBox.Size = new Size(75, 25);
            newCheckBox.TabIndex = 3;
            newCheckBox.Text = "Cargo";
            newCheckBox.UseVisualStyleBackColor = true;
            newCheckBox.Checked = true;
            newCheckBox.Enabled = false;
            isMandatoryCargo.Add(newCheckBox);

            return newCheckBox;
        }

        private CheckBox getLabelArea()
        {
            CheckBox newCheckBox = new CheckBox();
            newCheckBox.AutoSize = true;
            newCheckBox.Location = new Point(3, 12);
            newCheckBox.Size = new Size(75, 25);
            newCheckBox.TabIndex = 3;
            newCheckBox.Text = "Área";
            newCheckBox.UseVisualStyleBackColor = true;
            isMandatoryArea.Add(newCheckBox);

            return newCheckBox;
        }

        private CheckBox getLabelCompetencia()
        {
            CheckBox newCheckBox = new CheckBox();
            newCheckBox.AutoSize = true;
            newCheckBox.Location = new Point(3, 12);
            newCheckBox.Size = new Size(75, 25);
            newCheckBox.TabIndex = 3;
            newCheckBox.Text = "Competência";
            newCheckBox.UseVisualStyleBackColor = true;
            isMandatoryCompetencia.Add(newCheckBox);

            return newCheckBox;
        }

        private CheckBox getLabelGrau()
        {
            CheckBox newCheckBox = new CheckBox();
            newCheckBox.AutoSize = true;
            newCheckBox.Location = new Point(3, 12);
            newCheckBox.Size = new Size(75, 25);
            newCheckBox.TabIndex = 3;
            newCheckBox.Text = "Grau";
            newCheckBox.UseVisualStyleBackColor = true;
            isMandatoryGrau.Add(newCheckBox);

            return newCheckBox;
        }

        private CheckBox getLabelCurso()
        {
            CheckBox newCheckBox = new CheckBox();
            newCheckBox.AutoSize = true;
            newCheckBox.Location = new Point(3, 12);
            newCheckBox.Size = new Size(75, 25);
            newCheckBox.TabIndex = 3;
            newCheckBox.Text = "Curso";
            newCheckBox.UseVisualStyleBackColor = true;
            isMandatoryCurso.Add(newCheckBox);

            return newCheckBox;
        }

        private CheckBox getLabelInstituicao()
        {
            CheckBox newCheckBox = new CheckBox();
            newCheckBox.AutoSize = true;
            newCheckBox.Location = new Point(3, 12);
            newCheckBox.Size = new Size(75, 25);
            newCheckBox.TabIndex = 3;
            newCheckBox.Text = "Instituição";
            newCheckBox.UseVisualStyleBackColor = true;
            isMandatoryInstituicao.Add(newCheckBox);

            return newCheckBox;
        }

        private CheckBox getLabelInicio()
        {
            CheckBox newCheckBox = new CheckBox();
            newCheckBox.AutoSize = true;
            newCheckBox.Location = new Point(3, 12);
            newCheckBox.Size = new Size(75, 25);
            newCheckBox.TabIndex = 3;
            newCheckBox.Text = "Início";
            newCheckBox.UseVisualStyleBackColor = true;
            isMandatoryInicioEscolaridade.Add(newCheckBox);

            return newCheckBox;
        }

        private CheckBox getLabelConclusao()
        {
            CheckBox newCheckBox = new CheckBox();
            newCheckBox.AutoSize = true;
            newCheckBox.Location = new Point(3, 12);
            newCheckBox.Size = new Size(75, 25);
            newCheckBox.TabIndex = 3;
            newCheckBox.Text = "Conclusão";
            newCheckBox.UseVisualStyleBackColor = true;
            isMandatoryFimEscolaridade.Add(newCheckBox);

            return newCheckBox;
        }

        private CheckBox getLabelNivelCargo()
        {
            CheckBox newCheckBox = new CheckBox();
            newCheckBox.AutoSize = true;
            newCheckBox.Location = new Point(338, 12);
            newCheckBox.Size = new Size(65, 25);
            newCheckBox.TabIndex = 3;
            newCheckBox.Text = "Nível";
            newCheckBox.UseVisualStyleBackColor = true;
            isMandatoryNivelCargo.Add(newCheckBox);

            return newCheckBox;
        }

        private CheckBox getLabelExperiencia()
        {
            CheckBox newCheckBox = new CheckBox();
            newCheckBox.AutoSize = true;
            newCheckBox.Location = new Point(3, 62);
            newCheckBox.Size = new Size(134, 25);
            newCheckBox.TabIndex = 3;
            newCheckBox.Text = "Experiência";
            newCheckBox.UseVisualStyleBackColor = true;
            isMandatoryExperiencia.Add(newCheckBox);

            return newCheckBox;
        }

        private CheckBox getLabelBairro()
        {
            CheckBox newCheckBox = new CheckBox();
            newCheckBox.AutoSize = true;
            newCheckBox.Location = new Point(766, 297);
            newCheckBox.Size = new Size(76, 25);
            newCheckBox.TabIndex = 3;
            newCheckBox.Text = "Bairro";
            newCheckBox.UseVisualStyleBackColor = true;
            isMandatoryBairro.Add(newCheckBox);

            return newCheckBox;
        }

        private CheckBox getLabelCidade()
        {
            CheckBox newCheckBox = new CheckBox();
            newCheckBox.AutoSize = true;
            newCheckBox.Location = new Point(430, 297);
            newCheckBox.Size = new Size(85, 25);
            newCheckBox.TabIndex = 3;
            newCheckBox.Text = "Cidade";
            newCheckBox.UseVisualStyleBackColor = true;
            isMandatoryCidade.Add(newCheckBox);

            return newCheckBox;
        }

        private Label getLabelCidadeSemCheckBox()
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Anchor = AnchorStyles.Left;
            label.Location = new Point(164, 15);
            label.Size = new Size(146, 25);
            label.Text = "Cidade";

            return label;
        }

        private CheckBox getLabelDeficiencia()
        {
            CheckBox newCheckBox = new CheckBox();
            newCheckBox.AutoSize = true;
            newCheckBox.Location = new Point(25, 350);
            newCheckBox.Size = new Size(170, 25);
            newCheckBox.TabIndex = 3;
            newCheckBox.Text = "Deficiência";
            newCheckBox.UseVisualStyleBackColor = true;
            isMandatoryDeficiencia.Add(newCheckBox);

            return newCheckBox;
        }

        private CheckBox getLabelIdioma()
        {
            CheckBox newCheckBox = new CheckBox();
            newCheckBox.AutoSize = true;
            newCheckBox.Location = new Point(3, 20);
            newCheckBox.Size = new Size(75, 25);
            newCheckBox.TabIndex = 3;
            newCheckBox.Text = "Idioma";
            newCheckBox.UseVisualStyleBackColor = true;
            isMandatoryIdioma.Add(newCheckBox);

            return newCheckBox;
        }

        private CheckBox getLabelNivel()
        {
            CheckBox newCheckBox = new CheckBox();
            newCheckBox.AutoSize = true;
            newCheckBox.Location = new Point(3, 70);
            newCheckBox.Size = new Size(75, 25);
            newCheckBox.TabIndex = 3;
            newCheckBox.Text = "Nível";
            newCheckBox.UseVisualStyleBackColor = true;
            isMandatoryNivelIdioma.Add(newCheckBox);

            return newCheckBox;
        }
        private CheckBox getLabelEstado()
        {
            CheckBox newCheckBox = new CheckBox();
            newCheckBox.AutoSize = true;
            newCheckBox.Location = new Point(25, 297);
            newCheckBox.Size = new Size(83, 25);
            newCheckBox.TabIndex = 3;
            newCheckBox.Text = "Estado";
            newCheckBox.UseVisualStyleBackColor = true;
            isMandatoryEstado.Add(newCheckBox);

            return newCheckBox;
        }

        private Label getLabelA()
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Location = new Point(277, 225);
            label.Size = new Size(25, 25);
            label.TabIndex = 17;
            label.Text = "a";

            return label;
        }

        private CheckBox getLabelEstadoCivil()
        {
            CheckBox newCheckBox = new CheckBox();
            newCheckBox.AutoSize = true;
            newCheckBox.Location = new Point(25, 300);
            newCheckBox.Size = new Size(135, 25);
            newCheckBox.TabIndex = 3;
            newCheckBox.Text = "Estado Civil";
            newCheckBox.UseVisualStyleBackColor = true;
            isMandatoryEstadoCivil.Add(newCheckBox);

            return newCheckBox;
        }

        private CheckBox getLabelIdade()
        {
            CheckBox newCheckBox = new CheckBox();
            newCheckBox.AutoSize = true;
            newCheckBox.Location = new Point(25, 225);
            newCheckBox.Size = new Size(72, 25);
            newCheckBox.TabIndex = 3;
            newCheckBox.Text = "Idade";
            newCheckBox.UseVisualStyleBackColor = true;
            isMandatoryIdade.Add(newCheckBox);

            return newCheckBox;
        }

        private Label getLabelIdadeSemCheckBox()
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Anchor = AnchorStyles.Left;
            label.Location = new Point(164, 15);
            label.Size = new Size(146, 25);
            label.Text = "Idade";

            return label;
        }

        private CheckBox getLabelCNH()
        {
            CheckBox newCheckBox = new CheckBox();
            newCheckBox.AutoSize = true;
            newCheckBox.Location = new Point(500, 160);
            newCheckBox.Size = new Size(65, 25);
            newCheckBox.TabIndex = 3;
            newCheckBox.Text = "CNH";
            newCheckBox.UseVisualStyleBackColor = true;
            isMandatoryCNH.Add(newCheckBox);

            return newCheckBox;
        }

        private CheckBox getLabelSexo()
        {
            CheckBox newCheckBox = new CheckBox();
            newCheckBox.AutoSize = true;
            newCheckBox.Location = new Point(25, 160);
            newCheckBox.Size = new Size(64, 25);
            newCheckBox.TabIndex = 3;
            newCheckBox.Text = "Sexo";
            newCheckBox.UseVisualStyleBackColor = true;
            isMandatorySexo.Add(newCheckBox);

            return newCheckBox;
        }

        private CheckBox getLabelVagas()
        { 
            CheckBox newCheckBox = new CheckBox();
            newCheckBox.AutoSize = true;
            newCheckBox.Location = new Point(25, 100);
            newCheckBox.Size = new Size(199, 25);
            newCheckBox.TabIndex = 3;
            newCheckBox.Text = "Número de Vagas";
            newCheckBox.UseVisualStyleBackColor = true;
            newCheckBox.Checked = true;
            newCheckBox.Enabled = false;
            isMandatoryNrVagas.Add(newCheckBox);

            return newCheckBox;
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

        private Label getLabelData()
        {
            Label label = new Label();
            label.Anchor = AnchorStyles.Left;
            label.AutoSize = true;
            label.ImageAlign = ContentAlignment.MiddleLeft;
            label.Location = new Point(4, 15);
            label.Size = new Size(74, 25);
            label.TabIndex = 0;
            label.Text = "Data";
            label.TextAlign = ContentAlignment.MiddleLeft;

            return label;
        }

        private Label getLabelCargoSemCheckBox()
        {
            Label label = new Label();
            label.Anchor = AnchorStyles.Left;
            label.AutoSize = true;
            label.ImageAlign = ContentAlignment.MiddleLeft;
            label.Location = new Point(4, 15);
            label.Size = new Size(74, 25);
            label.TabIndex = 0;
            label.Text = "Cargo";
            label.TextAlign = ContentAlignment.MiddleLeft;

            return label;
        }

        private Label getLabelEditar()
        {
            Label label = new Label();
            label.Anchor = AnchorStyles.Left;
            label.AutoSize = true;
            label.ImageAlign = ContentAlignment.MiddleLeft;
            label.Location = new Point(4, 15);
            label.Size = new Size(74, 25);
            label.TabIndex = 0;
            label.Text = "Editar";
            label.TextAlign = ContentAlignment.MiddleLeft;

            return label;
        }

        private Label getLabelVisualizar()
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
            label.Location = new Point(24,24);
            label.Size = new Size(312, 32);
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
            label.Font = new Font("Segoe Print", 36F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            label.Location = new Point(360, 61);
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

        private ComboBox getComboBoxNivel()
        {
            ComboBox newComboBox = new ComboBox();
            newComboBox.Location = new Point(120, 60);
            newComboBox.Size = new Size(190, 25);
            newComboBox.Items.AddRange(mongo.DistinctField("idiomas.nivel"));
            newComboBox.TabIndex = 26;
            newComboBox.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            NivelIdioma.Add(newComboBox);

            return newComboBox;
        }

        private ComboBox getComboBoxGrau()
        {
            ComboBox newComboBox = new ComboBox();
            newComboBox.Location = new Point(120, 60);
            newComboBox.Size = new Size(400, 25);
            newComboBox.Items.AddRange(mongo.DistinctField("formacao.grau"));
            newComboBox.TabIndex = 26;
            newComboBox.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            Grau.Add(newComboBox);

            return newComboBox;
        }

        private ComboBox getComboBoxArea()
        {
            ComboBox newComboBox = new ComboBox();
            newComboBox.Location = new Point(120, 60);
            newComboBox.Size = new Size(300, 25);
            newComboBox.Items.AddRange(mongo.DistinctField("competencias.area"));
            newComboBox.TabIndex = 26;
            newComboBox.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            Area.Add(newComboBox);

            return newComboBox;
        }

        private ComboBox getComboBoxCargo()
        {
            ComboBox newComboBox = new ComboBox();
            newComboBox.Location = new Point(143, 8);
            newComboBox.Size = new Size(189, 33);
            newComboBox.TabIndex = 30;
            newComboBox.Items.AddRange(mongo.DistinctField("experiencia.cargo"));
            newComboBox.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            Cargo.Add(newComboBox);

            return newComboBox;
        }

        private ComboBox getComboBoxCompetencia1()
        {
            ComboBox newComboBox = new ComboBox();
            newComboBox.Location = new Point(120, 60);
            newComboBox.Size = new Size(300, 25);
            newComboBox.TabIndex = 26;
            newComboBox.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            newComboBox.Click += new EventHandler(this.setFilterCompetencia);
            Competencias1.Add(newComboBox);

            return newComboBox;
        }

        private ComboBox getComboBoxCompetencia2()
        {
            ComboBox newComboBox = new ComboBox();
            newComboBox.Location = new Point(120, 60);
            newComboBox.Size = new Size(300, 25);
            newComboBox.TabIndex = 26;
            newComboBox.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            newComboBox.Click += new EventHandler(this.setFilterCompetencia);
            Competencias2.Add(newComboBox);

            return newComboBox;
        }

        private ComboBox getComboBoxCompetencia3()
        {
            ComboBox newComboBox = new ComboBox();
            newComboBox.Location = new Point(120, 60);
            newComboBox.Size = new Size(300, 25);
            newComboBox.TabIndex = 26;
            newComboBox.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            newComboBox.Click += new EventHandler(this.setFilterCompetencia);
            Competencias3.Add(newComboBox);

            return newComboBox;
        }

        private ComboBox getComboBoxBairro()
        {
            ComboBox newComboBox = new ComboBox();
            newComboBox.Location = new Point(848, 294);
            newComboBox.Size = new Size(250, 33);
            newComboBox.TabIndex = 26;
            newComboBox.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            newComboBox.Click += new EventHandler(this.setFilterBairro);
            Bairro.Add(newComboBox);

            return newComboBox;
        }

        private ComboBox getComboBoxCidade()
        {
            ComboBox newComboBox = new ComboBox();
            newComboBox.Location = new Point(521, 294);
            newComboBox.Size = new Size(250, 33);
            newComboBox.TabIndex = 25;
            newComboBox.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            newComboBox.Click += new EventHandler(this.setFilterCidade);
            Cidade.Add(newComboBox);

            return newComboBox;
        }

        private ComboBox getComboBoxEstado()
        {
            ComboBox newComboBox = new ComboBox();
            newComboBox.Location = new Point(180, 294);
            newComboBox.Size = new Size(250, 33);
            newComboBox.Items.AddRange(mongo.DistinctField("estado"));
            newComboBox.TabIndex = 23;
            newComboBox.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            Estado.Add(newComboBox);

            return newComboBox;
        }

        private ComboBox getComboBoxNivelCargo()
        {
            ComboBox newComboBox = new ComboBox();
            newComboBox.Anchor = ((AnchorStyles)((AnchorStyles.Left | AnchorStyles.Right)));
            newComboBox.FormattingEnabled = true;
            newComboBox.Location = new Point(430, 58);
            newComboBox.Size = new Size(246, 33);
            newComboBox.Items.AddRange(mongo.DistinctField("experiencia.nivel"));
            newComboBox.TabIndex = 31;
            newComboBox.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            NivelCargo.Add(newComboBox);

            return newComboBox;
        }

        private ComboBox getComboBoxDeficiencia()
        {
            ComboBox newComboBox = new ComboBox();
            newComboBox.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            newComboBox.FormattingEnabled = true;
            newComboBox.Location = new Point(180, 254);
            newComboBox.Size = new Size(189, 31);
            newComboBox.Items.AddRange(mongo.DistinctField("especificacao_deficiencia"));
            newComboBox.TabIndex = 20;
            Deficiencia.Add(newComboBox);

            return newComboBox;
        }

        private ComboBox getComboBoxEstadoCivil()
        {
            ComboBox newComboBox = new ComboBox();
            newComboBox.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            newComboBox.FormattingEnabled = true;
            newComboBox.Items.AddRange(mongo.DistinctField("estado_civil"));
            newComboBox.Location = new Point(190, 300);
            newComboBox.Size = new Size(220, 31);
            newComboBox.TabIndex = 12;
            EstadoCivil.Add(newComboBox);

            return newComboBox;
        }
        
        private ComboBox getComboBoxCNH()
        {
            ComboBox newComboBox = new ComboBox();
            newComboBox.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            newComboBox.FormattingEnabled = true;
            newComboBox.Items.AddRange(mongo.DistinctField("cnh"));
            newComboBox.Location = new Point(600, 160);
            newComboBox.Size = new Size(200, 31);
            newComboBox.TabIndex = 8;
            CNH.Add(newComboBox);

            return newComboBox;
        }
        
        private ComboBox getComboBoxSexo()
        {
            ComboBox newComboBox = new ComboBox();
            newComboBox.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            newComboBox.FormattingEnabled = true;
            newComboBox.Items.AddRange(mongo.DistinctField("sexo"));
            newComboBox.Location = new Point(190, 160);
            newComboBox.Size = new Size(220, 31);
            newComboBox.TabIndex = 7;
            Sexo.Add(newComboBox);

            return newComboBox;
        }

        // 
        // CheckBox
        //
        private CheckBox checkBoxDesempregado()
        {
            CheckBox newCheckBox = new CheckBox();
            newCheckBox.AutoSize = true;
            newCheckBox.Location = new Point(500, 260);
            newCheckBox.Size = new Size(191, 29);
            newCheckBox.TabIndex = 14;
            newCheckBox.Text = "Desempregado";
            newCheckBox.UseVisualStyleBackColor = true;
            Desempregado = newCheckBox;

            return newCheckBox;
        }

        private CheckBox checkBoxDisponibilidadeViagem()
        {
            CheckBox newCheckBox = new CheckBox();
            newCheckBox.AutoSize = true;
            newCheckBox.Location = new Point(500, 300);
            newCheckBox.Size = new Size(335, 29);
            newCheckBox.TabIndex = 13;
            newCheckBox.Text = "Disponibilidade para viagens";
            newCheckBox.UseVisualStyleBackColor = true;
            DisponibilidadeViagens = newCheckBox;

            return newCheckBox;
        }

        private CheckBox checkBoxIncompleto()
        {
            CheckBox newCheckBox = new CheckBox();
            newCheckBox.AutoSize = true;
            newCheckBox.Location = new Point(435, 260);
            newCheckBox.Size = new Size(191, 29);
            newCheckBox.TabIndex = 14;
            newCheckBox.Text = "Incompleto";
            newCheckBox.UseVisualStyleBackColor = true;
            Incompleto.Add(newCheckBox);

            return newCheckBox;
        }
        // 
        // TableLayout
        // 
        private TableLayoutPanel addCargo()
        {
            TableLayoutPanel newCargo = new TableLayoutPanel();
            newCargo.ColumnCount = 6;
            newCargo.ColumnStyles.Add(new ColumnStyle());
            newCargo.ColumnStyles.Add(new ColumnStyle());
            newCargo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            newCargo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            newCargo.ColumnStyles.Add(new ColumnStyle());
            newCargo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            newCargo.Controls.Add(this.getTextBoxSalario(), 5, 1);
            newCargo.Controls.Add(this.getLabelSalario(), 4, 1);
            newCargo.Controls.Add(this.getComboBoxNivelCargo(), 5, 0);
            newCargo.Controls.Add(this.getTextBoxExperiencia(), 2, 1);
            newCargo.Controls.Add(this.getLabelNivelCargo(), 4, 0);
            newCargo.Controls.Add(this.getLabelExperiencia(), 1, 1);
            newCargo.Controls.Add(this.getComboBoxCargo(), 2, 0);
            newCargo.Controls.Add(this.getLabelCargo(), 1, 0);
            newCargo.Location = new Point(42, 3);
            newCargo.RowCount = 2;
            newCargo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            newCargo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            newCargo.Size = new Size(730, 100);
            newCargo.TabIndex = 40;

            return newCargo;
        }

        private TableLayoutPanel addDeficiencia()
        {
            TableLayoutPanel newDeficiencia = new TableLayoutPanel();
            newDeficiencia.ColumnCount = 3;
            newDeficiencia.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            newDeficiencia.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
            newDeficiencia.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            newDeficiencia.Controls.Add(this.getComboBoxDeficiencia(), 2, 0);
            newDeficiencia.Controls.Add(this.getLabelDeficiencia(), 1, 0);
            newDeficiencia.Location = new Point(20, 3);
            newDeficiencia.RowCount = 1;
            newDeficiencia.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            newDeficiencia.Size = new Size(400, 50);
            newDeficiencia.TabIndex = 40;

            return newDeficiencia;
        }

        private TableLayoutPanel addIdioma()
        {
            TableLayoutPanel newIdioma = new TableLayoutPanel();
            newIdioma.ColumnCount = 2;
            newIdioma.ColumnStyles.Add(new ColumnStyle());
            newIdioma.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            newIdioma.Controls.Add(this.getTextBoxIdioma(), 1, 0);
            newIdioma.Controls.Add(this.getLabelIdioma(), 0, 0);
            newIdioma.Controls.Add(this.getComboBoxNivel(), 1, 1);
            newIdioma.Controls.Add(this.getLabelNivel(), 0, 1);
            newIdioma.Location = new Point(10, 3);
            newIdioma.RowCount = 2;
            newIdioma.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            newIdioma.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            newIdioma.Size = new Size(300, 100);
            newIdioma.TabIndex = 40;

            return newIdioma;
        }

        private TableLayoutPanel addEscolaridade()
        {
            TableLayoutPanel newEscolaridade = new TableLayoutPanel();
            newEscolaridade.ColumnCount = 2;
            newEscolaridade.ColumnStyles.Add(new ColumnStyle());
            newEscolaridade.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            newEscolaridade.Controls.Add(this.getComboBoxGrau(), 1, 0);
            newEscolaridade.Controls.Add(this.getLabelGrau(), 0, 0);
            newEscolaridade.Controls.Add(this.checkBoxIncompleto(), 1, 1);
            newEscolaridade.Controls.Add(this.getLabelCurso(), 0, 2);
            newEscolaridade.Controls.Add(this.getTextBoxCurso(), 1, 2);
            newEscolaridade.Controls.Add(this.getLabelInstituicao(), 0, 3);
            newEscolaridade.Controls.Add(this.getTextBoxInstituicao(), 1, 3);
            newEscolaridade.Controls.Add(this.getLabelInicio(), 0, 4);
            newEscolaridade.Controls.Add(this.getTextBoxInicio(), 1, 4);
            newEscolaridade.Controls.Add(this.getLabelConclusao(), 0, 5);
            newEscolaridade.Controls.Add(this.getTextBoxConclusao(), 1, 5);
            newEscolaridade.Location = new Point(10, 3);
            newEscolaridade.RowCount = 6;
            newEscolaridade.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            newEscolaridade.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            newEscolaridade.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            newEscolaridade.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            newEscolaridade.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            newEscolaridade.RowStyles.Add(new RowStyle(SizeType.Percent, 22F));
            newEscolaridade.Size = new Size(540, 250);
            newEscolaridade.TabIndex = 40;

            return newEscolaridade;
        }

        private TableLayoutPanel addCompetencia()
        {
            TableLayoutPanel newCompetencia = new TableLayoutPanel();
            newCompetencia.ColumnCount = 2;
            newCompetencia.ColumnStyles.Add(new ColumnStyle());
            newCompetencia.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            newCompetencia.Controls.Add(this.getLabelArea(), 0, 0);
            newCompetencia.Controls.Add(this.getComboBoxArea(), 1, 0);
            newCompetencia.Controls.Add(this.getLabelCompetencia(), 0, 1);
            newCompetencia.Controls.Add(this.getComboBoxCompetencia1(), 1, 1);
            newCompetencia.Controls.Add(this.getComboBoxCompetencia2(), 1, 2);
            newCompetencia.Controls.Add(this.getComboBoxCompetencia3(), 1, 3);
            newCompetencia.Location = new Point(10, 3);
            newCompetencia.RowCount = 4;
            newCompetencia.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            newCompetencia.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            newCompetencia.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            newCompetencia.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            newCompetencia.Size = new Size(450, 250);
            newCompetencia.TabIndex = 40;

            return newCompetencia;
        }

        private TableLayoutPanel addEndereco()
        {
            TableLayoutPanel newEndereco = new TableLayoutPanel();
            newEndereco.ColumnCount = 3;
            newEndereco.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            newEndereco.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
            newEndereco.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            newEndereco.Controls.Add(this.getComboBoxBairro(), 2, 2);
            newEndereco.Controls.Add(this.getLabelBairro(), 1, 2);
            newEndereco.Controls.Add(this.getComboBoxCidade(), 2, 1);
            newEndereco.Controls.Add(this.getLabelCidade(), 1, 1);
            newEndereco.Controls.Add(this.getComboBoxEstado(), 2, 0);
            newEndereco.Controls.Add(this.getLabelEstado(), 1, 0);
            newEndereco.Location = new Point(20, 3);
            newEndereco.RowCount = 3;
            newEndereco.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            newEndereco.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            newEndereco.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            newEndereco.Size = new Size(500, 150);
            newEndereco.TabIndex = 40;

            return newEndereco;
        }

        // 
        // Events
        // 

        private void labelSalarioClick(object sender, EventArgs e, Label label)
        {
            label.ForeColor = Color.Red;
        }

        private void buscarCurriculosClick(object sender, EventArgs e)
        {
            panelBuscarCurriculos.Visible = true;
            panelResultados.Visible = false;
            panelHistoricoBuscas.Visible = false;
            panelAgendaEntrevistas.Visible = false;
            panelConfiguracoes.Visible = false;
            panelBuscarCurriculos2.Visible = false;
            panelBuscarCurriculos3.Visible = false;
        }

        private void historicoDeBuscasClick(object sender, EventArgs e)
        {
            int i;

            for (i = 0; i < 3; i++)
            {
                containerHistorico.RowCount++;
                containerHistorico.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                containerHistorico.Controls.Add(new Label() { Text = "Teste" + i, Anchor = AnchorStyles.Left, AutoSize = true }, 0, containerHistorico.RowCount - 1);
            }

            panelBuscarCurriculos.Visible = false;
            panelResultados.Visible = false;
            panelHistoricoBuscas.Visible = true;
            panelAgendaEntrevistas.Visible = false;
            panelConfiguracoes.Visible = false;
            panelBuscarCurriculos2.Visible = false;
            panelBuscarCurriculos3.Visible = false;
        }

        private void agendaDeEntrevistasClick(object sender, EventArgs e)
        {
            panelBuscarCurriculos.Visible = false;
            panelResultados.Visible = false;
            panelHistoricoBuscas.Visible = false;
            panelConfiguracoes.Visible = false;
            panelAgendaEntrevistas.Visible = true;
            panelBuscarCurriculos2.Visible = false;
            panelBuscarCurriculos3.Visible = false;
        }

        private void configuracoesClick(object sender, EventArgs e)
        {
            panelBuscarCurriculos.Visible = false;
            panelResultados.Visible = false;
            panelHistoricoBuscas.Visible = false;
            panelAgendaEntrevistas.Visible = false;
            panelConfiguracoes.Visible = true;
            panelBuscarCurriculos2.Visible = false;
            panelBuscarCurriculos3.Visible = false;
        }

        private void buttonVoltarClick(object sender, EventArgs e)
        {
            panelBuscarCurriculos2.Visible = false;
            panelBuscarCurriculos.Visible = false;
            panelResultados.Visible = false;
            panelHistoricoBuscas.Visible = false;
            panelAgendaEntrevistas.Visible = false;
            panelConfiguracoes.Visible = false;
            panelBuscarCurriculos3.Visible = false;
        }

        private void buttonVoltarClick2(object sender, EventArgs e)
        {
            panelBuscarCurriculos2.Visible = false;
            panelBuscarCurriculos.Visible = true;
            panelResultados.Visible = false;
            panelHistoricoBuscas.Visible = false;
            panelAgendaEntrevistas.Visible = false;
            panelConfiguracoes.Visible = false;
            panelBuscarCurriculos3.Visible = false;
        }

        private void buttonVoltarClick3(object sender, EventArgs e)
        {
            panelBuscarCurriculos2.Visible = true;
            panelBuscarCurriculos.Visible = false;
            panelResultados.Visible = false;
            panelHistoricoBuscas.Visible = false;
            panelAgendaEntrevistas.Visible = false;
            panelConfiguracoes.Visible = false;
            panelBuscarCurriculos3.Visible = false;
        }

        private void buttonProximoClick(object sender, EventArgs e)
        {
            panelBuscarCurriculos.Visible = false;
            panelResultados.Visible = false;
            panelHistoricoBuscas.Visible = false;
            panelAgendaEntrevistas.Visible = false;
            panelConfiguracoes.Visible = false;
            panelBuscarCurriculos2.Visible = true;
            panelBuscarCurriculos3.Visible = false;
        }

        private void buttonProximoClick2(object sender, EventArgs e)
        {
            panelBuscarCurriculos.Visible = false;
            panelResultados.Visible = false;
            panelHistoricoBuscas.Visible = false;
            panelAgendaEntrevistas.Visible = false;
            panelConfiguracoes.Visible = false;
            panelBuscarCurriculos2.Visible = false;
            panelBuscarCurriculos3.Visible = true;
        }

        private void plusAddCargo(object sender, EventArgs e)
        {
            containerCargo.RowCount++;
            containerCargo.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            containerCargo.Controls.Add(this.addCargo(), 1, containerCargo.RowCount - 1); //coluna, linha
        }

        private void plusAddIdioma(object sender, EventArgs e)
        {
            containerIdioma.RowCount++;
            containerIdioma.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            containerIdioma.Controls.Add(this.addIdioma(), 1, containerIdioma.RowCount - 1); //coluna, linha
        }

        private void plusAddEscolaridade(object sender, EventArgs e)
        {
            containerEscolaridade.RowCount++;
            containerEscolaridade.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            containerEscolaridade.Controls.Add(this.addEscolaridade(), 1, containerEscolaridade.RowCount - 1); //coluna, linha
        }

        private void plusAddCompetencia(object sender, EventArgs e)
        {
            containerCompetencia.RowCount++;
            containerCompetencia.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            containerCompetencia.Controls.Add(this.addCompetencia(), 1, containerCompetencia.RowCount - 1); //coluna, linha
        }

        private void plusAddDeficiencia(object sender, EventArgs e)
        {
            containerDeficiencia.RowCount++;
            containerDeficiencia.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            containerDeficiencia.Controls.Add(this.addDeficiencia(), 1, containerDeficiencia.RowCount - 1); //coluna, linha
        }

        private void plusAddEndereco(object sender, EventArgs e)
        {
            containerEndereco.RowCount++;
            containerEndereco.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            int insertedRowNum = containerEndereco.RowCount - 1;
            containerEndereco.Controls.Add(this.addEndereco(), 1, insertedRowNum); //coluna, linha
        }

        private void setFilterCidade(object sender, EventArgs e)
        {
            int i = 0;
            foreach (ComboBox cidade in Cidade)
            {
                ComboBox estado = (ComboBox)Estado[i];
                if (estado.SelectedItem != null)
                {
                    cidade.Items.Clear();
                    cidade.Items.AddRange(mongo.DistinctFieldWithQuery("cidade", mongo.DoQuery("{ estado : '"+estado.SelectedItem.ToString()+"' }")));
                }else
                {
                    cidade.Items.Clear();
                    cidade.Items.AddRange(mongo.DistinctField("cidade"));
                }
                i++;
            }
        }

        private void setFilterBairro(object sender, EventArgs e)
        {
            int i = 0;
            foreach (ComboBox bairro in Bairro)
            {
                ComboBox cidade = (ComboBox)Cidade[i];
                if (cidade.SelectedItem != null)
                {
                    bairro.Items.Clear();
                    bairro.Items.AddRange(mongo.DistinctFieldWithQuery("bairro", mongo.DoQuery("{ cidade : '" + cidade.SelectedItem.ToString() + "' }")));
                }
                else
                {
                    bairro.Items.Clear();
                    bairro.Items.AddRange(mongo.DistinctField("bairro"));
                }
                i++;
            }
        }

        private void setFilterCompetencia(object sender, EventArgs e)
        {
            int i = 0;
            foreach (ComboBox competencia in Competencias1)
            {
                ComboBox area = (ComboBox)Area[i];
                if (area.SelectedItem != null)
                {
                    competencia.Items.Clear();
                    competencia.Items.AddRange(mongo.DistinctFieldWithQuery("competencias.valores", mongo.DoQuery("{ competencias.area : '" + area.SelectedItem.ToString() + "' }")));
                }
                else
                {
                    competencia.Items.Clear();
                    competencia.Items.AddRange(mongo.DistinctField("competencias.valores"));
                }
                i++;
            }

            i = 0;
            foreach (ComboBox competencia in Competencias2)
            {
                ComboBox area = (ComboBox)Area[i];
                if (area.SelectedItem != null)
                {
                    competencia.Items.Clear();
                    competencia.Items.AddRange(mongo.DistinctFieldWithQuery("competencias.valores", mongo.DoQuery("{ competencias.area : '" + area.SelectedItem.ToString() + "' }")));
                }
                else
                {
                    competencia.Items.Clear();
                    competencia.Items.AddRange(mongo.DistinctField("competencias.valores"));
                }
                i++;
            }

            i = 0;
            foreach (ComboBox competencia in Competencias3)
            {
                ComboBox area = (ComboBox)Area[i];
                if (area.SelectedItem != null)
                {
                    competencia.Items.Clear();
                    competencia.Items.AddRange(mongo.DistinctFieldWithQuery("competencias.valores", mongo.DoQuery("{ competencias.area : '" + area.SelectedItem.ToString() + "' }")));
                }
                else
                {
                    competencia.Items.Clear();
                    competencia.Items.AddRange(mongo.DistinctField("competencias.valores"));
                }
                i++;
            }
        }

        private void buttonBuscarCurriculosClick(object sender, EventArgs e)
        {
            int i;
            int qtd = conf.getQuantidadeResultados();

            buscarResultadoMongo();

            
            for (i = 0; i < qtd;  i++)
            {
                containerResultados.RowCount++;
                containerResultados.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                containerResultados.Controls.Add(new Label() { Text = "Teste" + i, Anchor = AnchorStyles.Left, AutoSize = true }, 0, containerResultados.RowCount-1);
            }

            panelBuscarCurriculos.Visible = false;
            panelBuscarCurriculos2.Visible = false;
            panelBuscarCurriculos3.Visible = false;
            panelHistoricoBuscas.Visible = false;
            panelConfiguracoes.Visible = false;
            panelAgendaEntrevistas.Visible = false;
            panelResultados.Visible = true;
        }

        private String getTextBoxValue(TextBox box)
        {
            return ((TextBox)box).Text;
        }

        private String getComboBoxValue(ComboBox box)
        {
            if (box.SelectedItem != null)
                return box.SelectedItem.ToString();
            return "";
        }

        private void alertMandatoryEmpty()
        {
            MessageBox.Show("Por Favor, preencha todos os campos obrigatórios!", "Melhores Candidatos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }

        private void constructQueryWithTextField(Dictionary<string,ArrayList> valores, string key, CheckBox m, ArrayList query, Dictionary<string, ArrayList> fieldsDecision)
        {
            ArrayList queryValues = new ArrayList();
            foreach (var v in valores[key])
            {
                string text = "";
                if (v.GetType().Name.ToString() == "TextBox")
                {
                    text = this.getTextBoxValue((TextBox)v);
                } else if (v.GetType().Name.ToString() == "ComboBox")
                {
                    text = this.getComboBoxValue((ComboBox)v);
                }

                if (m.Checked == true)
                {
                    if (text == "") this.alertMandatoryEmpty();
                    queryValues.Add("\"" + text + "\"");
                } else
                {
                    ArrayList fieldValue = new ArrayList();
                    fieldValue.Add(text);
                    if (text != "") fieldsDecision.Add(key, fieldValue);
                }
            }

            string queryString = "";
            int queryValuesLength = queryValues.ToArray().Length;
            if (queryValuesLength > 0)
            {
                if (queryValues.ToArray().Length > 1)
                {
                    queryString += "{\"$and\": [";
                    int i = 0;
                    foreach (string queryValue in queryValues)
                    {
                        if (i > 0) queryString += ",";
                        queryString += "{\"" + key + "\":" + queryValue + "}";
                        i++;
                    }
                    queryString += "]}";
                }
                else
                {
                    queryString += "\"" + key + "\":" + queryValues[0];
                }
                query.Add(queryString);
            }
        }

        private void buscarResultadoMongo()
        {
            Dictionary<string, ArrayList> valores = new Dictionary<string, ArrayList>();
            valores.Add("vagas",NrVagas);
            valores.Add("sexo",Sexo);
            valores.Add("cnh",CNH);
            valores.Add("idade",Idade);
            valores.Add("estado_civil",EstadoCivil);
            valores.Add("especificacao_deficiencia", Deficiencia);
            valores.Add("estado", Estado);
            valores.Add("cidade",Cidade);
            valores.Add("bairro",Bairro);
            valores.Add("experiencia.cargo",Cargo);
            valores.Add("experiencia.nivel",NivelCargo);
            valores.Add("experiencia.duracao",Experiencia);
            valores.Add("objetivos.salario",Salario);
            valores.Add("idiomas.lingua",Idioma);
            valores.Add("idiomas.nivel",NivelIdioma);
            valores.Add("formacao.grau",Grau);
            valores.Add("formacao.curso",Curso);
            valores.Add("formacao.inicio",InicioEscolaridade);
            valores.Add("formacao.conclusao",FimEscolaridade);
            valores.Add("competencias.area",Area);
            valores.Add("competencias.valores",Competencias1);
            valores.Add("competencias.valores2",Competencias2);
            valores.Add("competencias.valores3",Competencias3);

            ArrayList mandatory = new ArrayList();
            mandatory.Add(isMandatoryNrVagas);
            mandatory.Add(isMandatorySexo);
            mandatory.Add(isMandatoryCNH);
            mandatory.Add(isMandatoryIdade);
            mandatory.Add(isMandatoryEstadoCivil);
            mandatory.Add(isMandatoryDeficiencia);
            mandatory.Add(isMandatoryEstado);
            mandatory.Add(isMandatoryCidade);
            mandatory.Add(isMandatoryBairro);
            mandatory.Add(isMandatoryCargo);
            mandatory.Add(isMandatoryNivelCargo);
            mandatory.Add(isMandatoryExperiencia);
            mandatory.Add(isMandatorySalario);
            mandatory.Add(isMandatoryIdioma);
            mandatory.Add(isMandatoryNivelIdioma);
            mandatory.Add(isMandatoryGrau);
            mandatory.Add(isMandatoryCurso);
            mandatory.Add(isMandatoryInicioEscolaridade);
            mandatory.Add(isMandatoryFimEscolaridade);
            mandatory.Add(isMandatoryArea);
            mandatory.Add(isMandatoryCompetencia);

            ArrayList textFields = new ArrayList();
            textFields.Add("sexo");
            textFields.Add("cnh");
            textFields.Add("estado_civil");
            textFields.Add("especificacao_deficiencia");
            textFields.Add("estado");
            textFields.Add("cidade");
            textFields.Add("bairro");
            textFields.Add("experiencia.cargo");
            textFields.Add("experiencia.nivel");
            textFields.Add("idiomas.lingua");
            textFields.Add("idiomas.nivel");
            textFields.Add("formacao.grau");
            textFields.Add("formacao.curso");
            textFields.Add("competencias.area");
            textFields.Add("competencias.valores");
            textFields.Add("competencias.valores2");
            textFields.Add("competencias.valores3");

            ArrayList intFields = new ArrayList();
            intFields.Add("idade");
            intFields.Add("experiencia.duracao");
            intFields.Add("objetivos.salario");

            ArrayList dateFields = new ArrayList();
            dateFields.Add("formacao.inicio");
            dateFields.Add("formacao.conclusao");

            int idx = 0;
            Dictionary<string, ArrayList> fieldsDecision = new Dictionary<string, ArrayList>();
            ArrayList query = new ArrayList();
            foreach (ArrayList arr in mandatory)
            {
                foreach (CheckBox m in arr)
                {
                    string key = valores.Keys.ElementAt(idx);
                    if (key != "vagas")
                    {
                        if (textFields.Contains(key))
                        {
                            constructQueryWithTextField(valores, key, m, query, fieldsDecision);
                        } else if (intFields.Contains(key))
                        {

                        } else if (dateFields.Contains(key))
                        {

                        }
                        //Debugger.Break();    
                    }
                }
                idx++;
            }

            string queryFinal = "{" + string.Join(",", query.ToArray()) + "}";
            ObjectId[] results = mongo.DistinctIDWithQuery(mongo.DoQuery(queryFinal));
            if (results.Length < 1)
            {
                MessageBox.Show("Sua pesquisa não encontrou nenhum resultado!", "Melhores Candidatos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            else
            {
                //Acionar script Matlab
            }
        }
    }
}
