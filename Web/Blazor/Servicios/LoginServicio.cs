using Blazor.Interfaces;
using Modelos;

namespace Blazor.Servicios
{
    public class LoginServicio : ILoginServicio //using de este e implementar interfaz
    {


        public Task<bool> ValidarUsuarioAsync(Login login)
        {
            throw new NotImplementedException();
        }
    }
}
