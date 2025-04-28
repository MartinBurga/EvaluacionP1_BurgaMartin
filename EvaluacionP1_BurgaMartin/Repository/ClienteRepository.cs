using EvaluacionP1_BurgaMartin.Models;

namespace EvaluacionP1_BurgaMartin.Repository
{
    public class ClienteRepository
    {
        public IEnumerable<Cliente> DevuelveClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            Cliente cliente1 = new Cliente();
            cliente1.Id = 1;
            cliente1.Nombre = "Juan Perez";
            cliente1.PagoRealizado = true;
            cliente1.FechaPago = DateOnly.FromDateTime(DateTime.Now);
            cliente1.Monto = 100.50;
            clientes.Add(cliente1);

            Cliente cliente2 = new Cliente();
            cliente2.Id = 2;
            cliente2.Nombre = "Maria Lopez";
            cliente2.PagoRealizado = false;
            cliente2.FechaPago = DateOnly.FromDateTime(DateTime.Now);
            cliente2.Monto = 200.75;
            clientes.Add(cliente2);

            return clientes;

        }
    }

}
