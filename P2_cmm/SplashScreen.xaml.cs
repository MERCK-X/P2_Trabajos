using System.Timers; // Asegúrate de agregar este using
using Microsoft.Maui.Controls;

namespace P2_cmm;

public partial class SplashScreen : ContentPage
{
    public SplashScreen()
    {
        InitializeComponent();

        // Configurar un temporizador de 5 segundos
        var timer = new System.Timers.Timer(5000); // Especifica System.Timers.Timer
        timer.Elapsed += OnTimerElapsed; // Asignar el evento correctamente
        timer.AutoReset = false; // Corregir la asignación
        timer.Start();
    }

    private async void OnTimerElapsed(object sender, ElapsedEventArgs e)
    {
        // Navegar a la página principal
        await Shell.Current.GoToAsync("//MainPage"); // Usar "//" para la ruta absoluta
    }
}