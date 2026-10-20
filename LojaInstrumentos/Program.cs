using LojaInstrumentos.Forms;

namespace LojaInstrumentos;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new SplashForm());
    }
}
