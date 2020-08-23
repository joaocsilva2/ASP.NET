using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Service;

namespace WebForms.Site.Cliente
{
    public partial class Cadastro : System.Web.UI.Page
    {
        public ClienteService cliSrv = new ClienteService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
                {
                    int codigo = Convert.ToInt32(Request.QueryString["ID"].ToString());
                    CarregarDados(codigo);
                }
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Domain.Entities.Cliente cliente = new Domain.Entities.Cliente();
                if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
                {
                   cliente.ID = Convert.ToInt32(Request.QueryString["ID"].ToString());
                }
                cliente.Nome = txtNome.Text;
                cliente.CPF = txtCPF.Text;
                cliente.Telefone = txtTelefone.Text;
                cliente.Endereco = txtEndereco.Text;
                cliSrv.Salvar(cliente);
                Response.Redirect("ListarCliente.aspx", true);
            }
            catch(Exception ex)
            {
                msg.InnerText = ex.Message;
            }
        }

        public void CarregarDados(int codigo)
        {
            try
            {
                var cli = cliSrv.ListarPorID(codigo);
                txtCPF.Text = cli.CPF;
                txtNome.Text = cli.Nome;
                txtTelefone.Text = cli.Telefone;
                txtEndereco.Text = cli.Endereco;
            }
            catch
            {

            }
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListarCliente.aspx", true);
        }
    }

}