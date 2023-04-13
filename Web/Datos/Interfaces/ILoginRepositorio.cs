using Modelos;

namespace Datos.Interfaces
{
    public interface ILoginRepositorio
    {
        //declaramos metodos para utilizar e implementar en la clase

        Task<bool> ValidarUsuarioAsync(Login login);
    }
}
