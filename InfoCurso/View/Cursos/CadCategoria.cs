
using InfoCurso.Model;
using System.Windows.Forms;

namespace Infocurso.Forms
{
    public partial class CadCategoria : Form
    {
        public CadCategoria()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, System.EventArgs e)
        {
            Categoria cat = new Categoria();
            cat.Nome = txtNome.Text;
            bool insert = Categoria.Insert(cat);
            if (insert)
            {
                lblSucesso.Text = "Categoria cadastrada com sucesso!";
                txtNome.Text = "";
            }
            InfoCurso.categorias.Add(cat);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            InfoCurso.ShowNewForm(new CadastroCurso());
        }
    }
}
