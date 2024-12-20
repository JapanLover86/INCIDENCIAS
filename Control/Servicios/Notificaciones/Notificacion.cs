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

        public async Task ShowSuccessAsync(string message, string title)
        {
            var js = $"toastr.success('{message}', '{title}');";
            await _jsRuntime.InvokeVoidAsync("toastr.success", message, title);
        }

        public async Task ShowErrorAsync(string message, string title)
        {
            var js = $"toastr.error('{message}', '{title}');";
            await _jsRuntime.InvokeVoidAsync("toastr.error", message, title);
        }

        public Task<bool> Confirmar(string mensaje)
        {
            // Implementar la lógica para mostrar un cuadro de confirmación
            return Task.FromResult(true); // Simulación para pruebas
        }

        public Task Exito(string mensaje)
        {
            // Implementar la lógica para mostrar una notificación de éxito
            Console.WriteLine($"Éxito: {mensaje}");
            return Task.CompletedTask;
        }

        public Task Error(string mensaje)
        {
            // Implementar la lógica para mostrar una notificación de error
            Console.WriteLine($"Error: {mensaje}");
            return Task.CompletedTask;
        }
    }
}