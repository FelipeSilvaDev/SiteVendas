using SiteVendas.Models;

namespace SiteVendas.Repositories.Interfaces
{
    public interface IPedidoRepository
    {
        void CriarPedido(Pedido pedido);
    }
}
