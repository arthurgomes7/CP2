namespace LojaInstrumentos.Forms
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object? sender, EventArgs e)
        {
            timerSplash.Start();
        }

        private void timerSplash_Tick(object? sender, EventArgs e)
        {
            progressBar.Value = Math.Min(100, progressBar.Value + 2);

            lblStatus.Text = progressBar.Value switch
            {
                < 40 => "Carregando catálogo...",
                < 80 => "Preparando vendas...",
                _ => "Quase pronto..."
            };

            if (progressBar.Value < 100) return;

            timerSplash.Stop();
            Hide();

            var menu = new MenuForm();
            menu.FormClosed += (_, _) => Close();
            menu.Show();
        }
    }
}
