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
    public partial class PaginaCurriculo : Form
    {
        public MongoDBClient mongo;
        

        public PaginaCurriculo()
        {
            InitializeComponent();
            this.setPageCurriculo();
        }

        private void setPageCurriculo()
        {
            mongo = new MongoDBClient();
            Curriculos curriculo = mongo.GetCurriculoById("590a666bde3d881e25bd63a7");

            this.sexo.Text = curriculo.sexo;
            this.idade.Text = (curriculo.idade).ToString() + "  anos";
            this.estadoCivil.Text = curriculo.estado_civil;
            this.carteiraHabilitacao.Text = curriculo.cnh.ToString();
            this.endereco.Text = curriculo.bairro + ", " + curriculo.cidade + " - " + curriculo.estado;

            var objetivos = curriculo.objetivos;
            
            var array = objetivos.Values.ToList()[1].ToString().Split('}');
            string cargo = "";
            for(int i=0; i<(array.Length-1); i++)
            {
                cargo = string.Concat(cargo,array[i].Substring(1).Split(',')[0].Split(':')[1].Replace('\"',' '));
                cargo = string.Concat(cargo, " ");
            }
            this.cargoDesejado.Text = cargo;

            this.pretensaoSalarial.Text = objetivos.Values.ToList()[0].ToString().Replace('\"', ' ').Replace('{', ' ').Replace('}', ' ');
            this.nivelHierarquico.Text = objetivos.Values.ToList()[2].ToString();

            string textIdioma = "";
            var idiomas = curriculo.idiomas;
            foreach(var value in idiomas.Values)
            {
                textIdioma = string.Concat(textIdioma,value["lingua"].ToString());
                textIdioma = string.Concat(textIdioma, "  ");
            }
            this.idiomas.Text = textIdioma;

            var textExperiencia = "";
            var experiencia = curriculo.experiencia;
            foreach(var value in experiencia.Values)
            {
                textExperiencia = string.Concat(textExperiencia, value["cargo"].ToString());
                textExperiencia = string.Concat(textExperiencia, "  ");
            }

            this.experiencias.Text = textExperiencia;

            var textFormacao = "";
            var formacao = curriculo.formacao;
            foreach (var value in formacao.Values)
            {
                textFormacao = string.Concat(textFormacao, value["curso"].ToString());
                textFormacao = string.Concat(textFormacao, "  ");
            }

            this.formacaoAcademica.Text = textFormacao;
        }

    }
}
