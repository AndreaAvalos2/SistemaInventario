using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos.Repositorio.IRepositorio
{
    public interface IRepositorio<T> where T : class
    {
        // Retorna tipo de dato generico cuando se lance la funcion obtener
        Task<T> obtener(int id); // Busqueda directa por identificador
                         // Obtener todos una lista de elementos
        Task<IEnumerable <T>> ObtenerTodos(
            //Parametro a recibir "Expresion", si no se le manda ningun dato se pone como nulo
            Expression<Func<T, bool>>filtro = null,
                //funcion para ordenar, ya sea una interfaz
                Func<IQueryable<T>,IOrderedQueryable<T>> orderBy = null, 
                string incluirPropiedades = null, 
                bool isTracking = true 
            );

        Task<T> ObtenerPrimero (
            //Parametro a recibir "Expresion", si no se le manda ningun dato se pone como nulo
            Expression<Func<T, bool>> filtro = null, // Para saber si viene un parametro
                string incluirPropiedades = null,
                bool isTracking = true
            );
        // Agregar
          void Task<Agregar>(T entidad);
        // Remover   
        void Remover(T entidad);

        void RemoverRango(IEnumerable<T> entidad);
        // Datos Asincronos , Tareas Asincronas - > 

    }
}