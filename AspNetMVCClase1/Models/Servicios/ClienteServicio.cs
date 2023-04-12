using AspNetMVCClase1.Models.Entidades;

namespace AspNetMVCClase1.Models.Servicios
{
    public class ClienteServicio
    {
        private static List<Cliente> Clientes { get; set; }

        public ClienteServicio()
        {
            if (Clientes == null)
            {
                Clientes = new List<Cliente>() {
                    new Cliente() { Id= 1, Edad= 30, RazonSocial="Cliente 1 SA"},
                    new Cliente() { Id= 2, Edad= 34, RazonSocial="Cliente 2 SA"},
                    new Cliente() { Id= 3, Edad= 38, RazonSocial="Cliente 3 SA"},
                };


            }
        
        }


        public List<Cliente> GetClientes()
        {
            return Clientes;
        }

        public Cliente? GetById(int id)
        {
            foreach (var cli in Clientes)
            {
                if (cli.Id == id)
                {
                    return cli;
                }
            
            }
            return null;
        }

        public void SaveCliente(Cliente cli)
        {

            Clientes.Add(cli);
            //RepositoryCliente.SaveCliente();
        }


    }
}
