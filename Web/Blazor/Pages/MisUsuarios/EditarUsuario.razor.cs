using Blazor.Interfaces;
using Microsoft.AspNetCore.Components;
using Modelos;

namespace Blazor.Pages.MisUsuarios
{
    public partial class EditarUsuario
    {
        [Inject] private IUsuarioServicio usuarioServicio { get; set; }
        [Inject] private NavigationManager navigationManager { get; set; }
        private Usuario user = new Usuario();
        [Parameter] public string CodigoUsuario { get; set; }

        protected override async Task OnInitializedAsync()
        {
            if (!string.IsNullOrEmpty(CodigoUsuario))
            {
                user = await usuarioServicio.GetPorCodigoAsync(CodigoUsuario);
            }
        }
    }
}
