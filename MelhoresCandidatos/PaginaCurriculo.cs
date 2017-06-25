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
            Curriculos curriculo = mongo.GetCurriculoById("590a6724de3d881e25bd66dd");

            this.sexo.Text = curriculo.sexo;

        }

    }
}
