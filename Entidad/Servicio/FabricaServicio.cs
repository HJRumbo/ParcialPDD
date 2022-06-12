namespace Entidad.Servicio
{
    public class FabricaServicio
    {
        public Servicio ObtenerServicio(int tipo)
        {
            if (tipo == 1)
            {
                return new OrdenDeCompra();
            }
            else if (tipo == 2)
            {
                return new Pedido();
            }
            else if (tipo == 3)
            {
                return new Factura();
            }
            else
            {
                return new Cotizacion();
            }
        }
    }
}