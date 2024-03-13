using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos.Repositorio.IRepositorio
{
    public interface IUnidadTrabajo : IDisposable //Libreria para deja en memoria que se utiliza constantemente
    {
        //Aqui se van a agregar todos los modelos 
        IBodegaRepositorio Bodega { get; }

        //Tarea asincrona
        Task Guardar();


    }
}
