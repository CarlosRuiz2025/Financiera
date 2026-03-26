using Financiera.Entities;

namespace Financiera.Data.Infrastructure
{
    internal interface IPrestamo
    {
        List<Prestamo> Listar();
        Prestamo ObtenerPorId(int id);
        int Regitrar(Prestamo prestamo);
    }
}
