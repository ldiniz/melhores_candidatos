namespace MelhoresCandidatos
{
    partial class Index
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelBuscarCurriculos = new System.Windows.Forms.Panel();
            this.containerCargo = new System.Windows.Forms.TableLayoutPanel();
            this.containerDeficiencia = new System.Windows.Forms.TableLayoutPanel();
            this.containerEndereco = new System.Windows.Forms.TableLayoutPanel();
            this.panelResultados = new System.Windows.Forms.Panel();
            this.containerResultados = new System.Windows.Forms.TableLayoutPanel();
            this.panelConfiguracoes = new System.Windows.Forms.Panel();
            this.panelHistoricoBuscas = new System.Windows.Forms.Panel();
            this.panelAgendaEntrevistas = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelBuscarCurriculos.SuspendLayout();
            this.containerCargo.SuspendLayout();
            this.containerDeficiencia.SuspendLayout();
            this.containerEndereco.SuspendLayout();
            this.panelResultados.SuspendLayout();
            this.containerResultados.SuspendLayout();
            this.panelConfiguracoes.SuspendLayout();
            this.panelHistoricoBuscas.SuspendLayout();
            this.panelAgendaEntrevistas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.buttonBuscarCurriculos(), 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonHistoricoDeBuscas(), 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonAgendaDeEntrevistas(), 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(440, 228);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 200);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelBuscarCurriculos
            // 
            this.panelBuscarCurriculos.AutoScroll = true;
            this.panelBuscarCurriculos.Controls.Add(this.containerCargo);
            this.panelBuscarCurriculos.Controls.Add(this.containerEndereco);
            this.panelBuscarCurriculos.Controls.Add(this.containerDeficiencia);
            this.panelBuscarCurriculos.Controls.Add(this.buttonVoltar());
            this.panelBuscarCurriculos.Controls.Add(this.getLabelA());
            this.panelBuscarCurriculos.Controls.Add(this.getTextBox3());
            this.panelBuscarCurriculos.Controls.Add(this.getTextBox2());
            this.panelBuscarCurriculos.Controls.Add(this.checkBoxDesempregado());
            this.panelBuscarCurriculos.Controls.Add(this.checkBoxDisponibilidadeViagem());
            this.panelBuscarCurriculos.Controls.Add(this.getComboBoxEstadoCivil());
            this.panelBuscarCurriculos.Controls.Add(this.getLabelEstadoCivil());
            this.panelBuscarCurriculos.Controls.Add(this.getLabelIdade());
            this.panelBuscarCurriculos.Controls.Add(this.getLabelCNH());
            this.panelBuscarCurriculos.Controls.Add(this.getComboBoxCNH());
            this.panelBuscarCurriculos.Controls.Add(this.getComboBoxSexo());
            this.panelBuscarCurriculos.Controls.Add(this.getLabelSexo());
            this.panelBuscarCurriculos.Controls.Add(this.buttonBuscar());
            this.panelBuscarCurriculos.Controls.Add(this.getTextBox1());
            this.panelBuscarCurriculos.Controls.Add(this.getLabelBuscarCurriculos());
            this.panelBuscarCurriculos.Controls.Add(this.getLabelVagas());
            this.panelBuscarCurriculos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBuscarCurriculos.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBuscarCurriculos.Location = new System.Drawing.Point(0, 0);
            this.panelBuscarCurriculos.Name = "panelBuscarCurriculos";
            this.panelBuscarCurriculos.Size = new System.Drawing.Size(1076, 656);
            this.panelBuscarCurriculos.TabIndex = 7;
            this.panelBuscarCurriculos.Visible = false;
            // 
            // containerCargo
            // 
            this.containerCargo.AutoSize = true;
            this.containerCargo.ColumnCount = 2;
            this.containerCargo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.containerCargo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 666F));
            this.containerCargo.RowCount = 1;
            this.containerCargo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.containerCargo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.containerCargo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.containerCargo.Controls.Add(this.buttonPlusCargo(), 0, 0);
            this.containerCargo.Controls.Add(this.addCargo(), 1, 0);
            this.containerCargo.Location = new System.Drawing.Point(30, 347);
            this.containerCargo.Name = "containerCargo";
            this.containerCargo.TabIndex = 41;
            // 
            // containerDeficiencia
            // 
            this.containerDeficiencia.AutoSize = true;
            this.containerDeficiencia.ColumnCount = 2;
            this.containerDeficiencia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.containerDeficiencia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 666F));
            this.containerDeficiencia.RowCount = 1;
            this.containerDeficiencia.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.containerDeficiencia.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.containerDeficiencia.Controls.Add(this.buttonPlusDeficiencia(), 0, 0);
            this.containerDeficiencia.Controls.Add(this.addDeficiencia(), 1, 0);
            this.containerDeficiencia.Location = new System.Drawing.Point(30, 257);
            this.containerDeficiencia.Name = "containerDeficiencia";
            this.containerDeficiencia.TabIndex = 41;
            // 
            // containerEndereco
            // 
            this.containerEndereco.AutoSize = true;
            this.containerEndereco.ColumnCount = 2;
            this.containerEndereco.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.containerEndereco.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 900F));
            this.containerEndereco.RowCount = 1;
            this.containerEndereco.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.containerEndereco.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.containerEndereco.Controls.Add(this.buttonPlusEndereco(), 0, 0);
            this.containerEndereco.Controls.Add(this.addEndereco(), 1, 0);
            this.containerEndereco.Location = new System.Drawing.Point(30, 302);
            this.containerEndereco.Name = "containerEndereco";
            this.containerEndereco.TabIndex = 41;
            // 
            // panelResultados
            // 
            this.panelResultados.Controls.Add(this.containerResultados);
            this.panelResultados.Controls.Add(this.buttonVoltar());
            this.panelResultados.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelResultados.Location = new System.Drawing.Point(0, 0);
            this.panelResultados.Name = "panelResultados";
            this.panelResultados.Size = new System.Drawing.Size(1076, 656);
            this.panelResultados.TabIndex = 42;
            this.panelResultados.Visible = false;
            // 
            // containerResultados
            // 
            this.containerResultados.AutoSize = true;
            this.containerResultados.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.containerResultados.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.containerResultados.ColumnCount = 8;
            this.containerResultados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.containerResultados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.containerResultados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.containerResultados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.containerResultados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.containerResultados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.containerResultados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.containerResultados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.containerResultados.Controls.Add(this.getLabelNome(), 0, 0);
            this.containerResultados.Controls.Add(this.getLabelIdade(), 1, 0);
            this.containerResultados.Controls.Add(this.getLabelEscolaridade(), 2, 0);
            this.containerResultados.Controls.Add(this.getLabelPretensao(), 3, 0);
            this.containerResultados.Controls.Add(this.getLabelEstado(), 4, 0);
            this.containerResultados.Controls.Add(this.getLabelCidade(), 5, 0);
            this.containerResultados.Controls.Add(this.getLabelCurriculo(), 6, 0);
            this.containerResultados.Controls.Add(this.getLabelEntrevista(), 7, 0);
            this.containerResultados.Location = new System.Drawing.Point(30, 112);
            this.containerResultados.Name = "containerResultados";
            this.containerResultados.RowCount = 1;
            this.containerResultados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.containerResultados.Size = new System.Drawing.Size(998, 56);
            this.containerResultados.TabIndex = 1;
            // 
            // panelConfiguracoes
            // 
            this.panelConfiguracoes.Controls.Add(this.getLabelConfig());
            this.panelConfiguracoes.Controls.Add(this.buttonVoltar());
            this.panelConfiguracoes.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelConfiguracoes.Location = new System.Drawing.Point(0, 0);
            this.panelConfiguracoes.Name = "panelConfiguracoes";
            this.panelConfiguracoes.Size = new System.Drawing.Size(1076, 656);
            this.panelConfiguracoes.TabIndex = 2;
            this.panelConfiguracoes.Visible = false;
            // 
            // panelHistoricoBuscas
            // 
            this.panelHistoricoBuscas.Controls.Add(this.getLabelHistoricoBuscas());
            this.panelHistoricoBuscas.Controls.Add(this.buttonVoltar());
            this.panelHistoricoBuscas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHistoricoBuscas.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelHistoricoBuscas.Location = new System.Drawing.Point(0, 0);
            this.panelHistoricoBuscas.Name = "panelHistoricoBuscas";
            this.panelHistoricoBuscas.Size = new System.Drawing.Size(1076, 656);
            this.panelHistoricoBuscas.TabIndex = 2;
            this.panelHistoricoBuscas.Visible = false;
            // 
            // panelAgendaEntrevistas
            // 
            this.panelAgendaEntrevistas.Controls.Add(this.getLabelAgendaEntrevistas());
            this.panelAgendaEntrevistas.Controls.Add(this.buttonVoltar());
            this.panelAgendaEntrevistas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAgendaEntrevistas.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelAgendaEntrevistas.Location = new System.Drawing.Point(0, 0);
            this.panelAgendaEntrevistas.Name = "panelAgendaEntrevistas";
            this.panelAgendaEntrevistas.Size = new System.Drawing.Size(1076, 656);
            this.panelAgendaEntrevistas.TabIndex = 2;
            this.panelAgendaEntrevistas.Visible = false;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1076, 656);
            this.Controls.Add(this.panelBuscarCurriculos);
            this.Controls.Add(this.panelHistoricoBuscas);
            this.Controls.Add(this.panelAgendaEntrevistas);
            this.Controls.Add(this.panelConfiguracoes);
            this.Controls.Add(this.panelResultados);
            this.Controls.Add(this.buttonConfiguracoes());
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.getLabelMelhoresCandidatos());
            this.Name = "Index";
            this.Text = "Melhores Candidatos";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelBuscarCurriculos.ResumeLayout(false);
            this.panelBuscarCurriculos.PerformLayout();
            this.containerCargo.ResumeLayout(false);
            this.containerCargo.PerformLayout();
            this.containerDeficiencia.ResumeLayout(false);
            this.containerDeficiencia.PerformLayout();
            this.containerEndereco.ResumeLayout(false);
            this.containerEndereco.PerformLayout();
            this.panelResultados.ResumeLayout(false);
            this.panelResultados.PerformLayout();
            this.containerResultados.ResumeLayout(false);
            this.containerResultados.PerformLayout();
            this.panelConfiguracoes.ResumeLayout(false);
            this.panelConfiguracoes.PerformLayout();
            this.panelHistoricoBuscas.ResumeLayout(false);
            this.panelHistoricoBuscas.PerformLayout();
            this.panelAgendaEntrevistas.ResumeLayout(false);
            this.panelAgendaEntrevistas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelBuscarCurriculos;
        private System.Windows.Forms.TableLayoutPanel containerCargo;
        private System.Windows.Forms.TableLayoutPanel containerDeficiencia;
        private System.Windows.Forms.TableLayoutPanel containerEndereco;
        private System.Windows.Forms.Panel panelResultados;
        private System.Windows.Forms.TableLayoutPanel containerResultados;
        private System.Windows.Forms.Panel panelHistoricoBuscas;
        private System.Windows.Forms.Panel panelConfiguracoes;
        private System.Windows.Forms.Panel panelAgendaEntrevistas;
    }
}

