using System;
using System.Collections.Generic;
using System.Text;

namespace Financiera.Data.Infrastructure
{
    internal interface IGeneric<Entity> where Entity : class
    {
        List<Entity> Listar();
        Entity ObtenerPorId(int id);
        int Registrar(Entity entity);
        bool Modificar(Entity entity);
        bool Eliminar(int id);
    }
}
