using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Repository;


namespace Service
{
    public class ClienteService
    {
        public void Salvar(Cliente cliente)
        {
            try
            {
                ClienteRepository cliRep = new ClienteRepository();
                cliRep.Save(cliente);
            }
            catch
            {
                throw new Exception();
            }
        }

        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();
            try
            {
                ClienteRepository cliRep = new ClienteRepository();
                lista = cliRep.Get();
            }
            catch
            {
                throw new Exception();
            }
            return lista;
        }

        public Cliente ListarPorID(int ID)
        {
            Cliente cliente = new Cliente();
            try
            {
                ClienteRepository cliRep = new ClienteRepository();
                cliente = cliRep.Get(ID);
            }
            catch
            {
                throw new Exception();
            }
            return cliente;

        }

        public void Excluir(int ID)
        {
            try
            {
                ClienteRepository cliRep = new ClienteRepository();
                cliRep.Delete(ID);
            }
            catch
            {
                throw new Exception();
            }
        }

    }
}
