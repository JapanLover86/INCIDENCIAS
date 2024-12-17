using Microsoft.JSInterop;

namespace AcmeSacBlazorDemoWeb.Servicios.Notificaciones
{
    public class Notificacion
    {
        private readonly IJSRuntime _jsRuntime;

        public Notificacion(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public void ShowSuccess(string message, string title)
        {
            var js = $"toastr.success('{message}', '{title}');";
            _jsRuntime.InvokeVoidAsync("eval", js);
        }

        public void ShowError(string message, string title)
        {
            var js = $"toastr.error('{message}', '{title}');";
            _jsRuntime.InvokeVoidAsync("eval", js);
        }
    }
}