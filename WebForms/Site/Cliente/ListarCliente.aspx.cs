using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Service;

namespace WebForms.Site.Cliente
{
    public partial class ListarCliente : System.Web.UI.Page
    {

        public ClienteService cliSrv = new ClienteService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ListarDados();
            }
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cadastro.aspx",true);
        }

        protected void gdvDados_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int codigo = 0;
            if(e.CommandName == "Editar")
            {
                codigo = Convert.ToInt32(e.CommandArgument.ToString());
                Response.Redirect("Cadastro.aspx?ID=" + codigo,true);
            }
            if(e.CommandName == "Excluir")
            {
                codigo = Convert.ToInt32(e.CommandArgument.ToString());
                cliSrv.Excluir(codigo);
                ListarDados();
            }
        }

        public void ListarDados()
        {
            gdvDados.DataSource = cliSrv.Listar();
            gdvDados.DataBind();
        }
    }
}