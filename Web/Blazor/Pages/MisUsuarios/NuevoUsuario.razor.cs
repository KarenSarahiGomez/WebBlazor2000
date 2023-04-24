using Blazor.Interfaces;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Modelos;

namespace Blazor.Pages.MisUsuarios
{
    public partial class NuevoUsuario
    {
        [Inject] private IUsuarioServicio usuarioServicio { get; set; }
        [Inject] private NavigationManager navigationManager { get; set; }
        [Inject] private SweetAlertService Swal { get; set; }

        private Usuario user = new Usuario();
        [Parameter] public string CodigoUsuario { get; set; }

        string imgUrl = string.Empty;

        private async Task SeleccionarImagen(InputFileChangeEventArgs e)
        {
            IBrowserFile imgFile = e.File;
            var buffers = new byte[imgFile.Size]; //arreglo de bytes
            user.Foto = buffers; //objeto user al arreglo de bytes
            await imgFile.OpenReadStream().ReadAsync(buffers); //mostrar una vista previa de la img en pantalla
            string imageType = imgFile.ContentType; //para saber el tipo de imagen img, jpn, pgn
            imgUrl = $"data: {imageType};base64,{Convert.ToBase64String(buffers)}"; //foto a visualizar //visualizar la imagen, despues de [parameter]
        }

        protected async void Guardar()
        {
            if (string.IsNullOrWhiteSpace(user.CodigoUsuario) || string.IsNullOrWhiteSpace(user.Nombre) ||
                string.IsNullOrWhiteSpace(user.Contrasena) || string.IsNullOrWhiteSpace(user.Rol) || user.Rol == "Seleccionar")
            {
                return;
            }

            user.FechaCreación = DateTime.Now;

            bool inserto = await usuarioServicio.NuevoAsync(user);
            if (inserto)
            {
                await Swal.FireAsync("Felicidades", "Usuario Guardado", SweetAlertIcon.Success);
            }
            else
            {
                await Swal.FireAsync("Error", "No se pudo guardar el usuario", SweetAlertIcon.Error);
            }
        }

        protected async void Cancelar()
        {
            navigationManager.NavigateTo("/Usuarios");
        }
    }
}
