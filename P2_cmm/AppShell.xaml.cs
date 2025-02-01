namespace P2_cmm;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Navegar a la página de SplashScreen al inicio
        CurrentItem = Items[0];
    }
}