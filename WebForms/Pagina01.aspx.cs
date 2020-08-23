using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class Pagina01 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = string.Format("Nome:  {0} - {1} Telefone: {2}. Cadastrado com Sucesso.",txtNome.Text,txtSobreNome.Text,txtTelefone.Text);
        }
    }
}