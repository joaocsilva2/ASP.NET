using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Domain.Entities;

namespace Repository
{
    public class ClienteRepository
    {
        public string conexao = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;

        public void Save(Cliente cliente)
        {
            try
            {
                using (var conn = new SqlConnection(conexao))
                {
                    var cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    if(cliente.ID == 0)
                    {
                        cmd.CommandText = "insert into Cliente(CPF,Nome,Telefone,Endereco) values (@CPF,@Nome,@Telefone,@Endereco)";
                    }
                    else
                    {
                        cmd.CommandText = "Update Cliente set CPF = @CPF, Nome = @Nome, Telefone = @Telefone,Endereco = @Endereco where ID = @ID";
                        cmd.Parameters.AddWithValue("ID", cliente.ID);
                    }
                    cmd.Parameters.AddWithValue("CPF", cliente.CPF);
                    cmd.Parameters.AddWithValue("Nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("Telefone", cliente.Telefone);
                    cmd.Parameters.AddWithValue("Endereco", cliente.Endereco);
                    try
                    {
                        conn.Open();
                        int ret = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message + ex.InnerException);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " " + ex.InnerException);
            }
        }
        public Cliente Get(int ID)
        {
            Cliente cliente = new Cliente();
            try
            {
                using (var conn = new SqlConnection(conexao))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "Select ID, Nome, CPF, Endereco, Telefone from Cliente where ID = @ID";
                    cmd.Parameters.AddWithValue("ID", ID);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while(dr.Read())
                    {
                        cliente.ID = Convert.ToInt32(dr["ID"]);
                        cliente.Nome = dr["Nome"].ToString();
                        cliente.CPF = dr["CPF"].ToString();
                        cliente.Telefone = dr["Telefone"].ToString();
                        cliente.Endereco = dr["Endereco"].ToString();
                    }
                    conn.Close();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message + " " + ex.InnerException);
            }
            return cliente;
        }

        public List<Cliente> Get()
        {
            List<Cliente> lista = new List<Cliente>();
            try
            {
                using (var conn = new SqlConnection(conexao))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "Select ID, Nome, CPF, Endereco, Telefone from Cliente order by Nome";
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Cliente cliente = new Cliente();
                        cliente.ID = Convert.ToInt32(dr["ID"]);
                        cliente.Nome = dr["Nome"].ToString();
                        cliente.CPF = dr["CPF"].ToString();
                        cliente.Telefone = dr["Telefone"].ToString();
                        cliente.Endereco = dr["Endereco"].ToString();
                        lista.Add(cliente);
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " " + ex.InnerException);
            }
            return lista;
        }

        public void Delete(int ID)
        {
            Cliente cliente = new Cliente();
            try
            {
                using (var conn = new SqlConnection(conexao))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "Delete from Cliente where ID = @ID";
                    cmd.Parameters.AddWithValue("ID", ID);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " " + ex.InnerException);
            }
        }
    }

}
