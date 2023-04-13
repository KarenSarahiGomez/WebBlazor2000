using Modelos;

namespace Blazor.Interfaces
{
    public interface ILoginServicio
    {
        //declaramos metodos para utilizar e implementar en la clase

        Task<bool> ValidarUsuarioAsync(Login login);
    }
}
