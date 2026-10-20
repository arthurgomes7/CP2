namespace LojaInstrumentos.Forms
{
    partial class SplashForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitulo = new Label();
            lblStatus = new Label();
            progressBar = new ProgressBar();
            timerSplash = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            //
            // lblTitulo
            //
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(520, 160);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Loja de Instrumentos Musicais";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblStatus
            //
            lblStatus.Dock = DockStyle.Top;
            lblStatus.Font = new Font("Segoe UI", 10F);
            lblStatus.ForeColor = Color.Gainsboro;
            lblStatus.Location = new Point(0, 160);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(520, 40);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Carregando...";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            //
            // progressBar
            //
            progressBar.Location = new Point(60, 230);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(400, 12);
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 2;
            //
            // timerSplash
            //
            timerSplash.Interval = 40;
            timerSplash.Tick += timerSplash_Tick;
            //
            // SplashForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 46);
            ClientSize = new Size(520, 300);
            Controls.Add(progressBar);
            Controls.Add(lblStatus);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loja de Instrumentos Musicais";
            Load += SplashForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Label lblStatus;
        private ProgressBar progressBar;
        private System.Windows.Forms.Timer timerSplash;
    }
}
