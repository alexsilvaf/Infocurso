using Infocurso;
using Infocurso.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infocurso
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnAulas_Click(object sender, EventArgs e)
        {
            InfoCurso.ShowNewForm(new Cursos());
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            InfoCurso.ShowNewForm(new CadastroCurso());
        }
    }
}
