namespace LojaInstrumentos.Forms
{
    partial class VendaForm
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
            DataGridViewCellStyle moedaStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle moedaStyle2 = new DataGridViewCellStyle();
            lblCliente = new Label();
            txtCliente = new TextBox();
            lblInstrumento = new Label();
            cboInstrumento = new ComboBox();
            lblPreco = new Label();
            lblEstoque = new Label();
            lblQuantidade = new Label();
            nudQuantidade = new NumericUpDown();
            btnAdicionar = new Button();
            dgvItens = new DataGridView();
            colNome = new DataGridViewTextBoxColumn();
            colPreco = new DataGridViewTextBoxColumn();
            colQuantidade = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            btnRemover = new Button();
            lblTotal = new Label();
            btnFinalizar = new Button();
            btnFechar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvItens).BeginInit();
            SuspendLayout();
            //
            // lblCliente
            //
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(20, 25);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(48, 19);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            //
            // txtCliente
            //
            txtCliente.Location = new Point(110, 22);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(320, 25);
            txtCliente.TabIndex = 1;
            //
            // lblInstrumento
            //
            lblInstrumento.AutoSize = true;
            lblInstrumento.Location = new Point(20, 65);
            lblInstrumento.Name = "lblInstrumento";
            lblInstrumento.Size = new Size(76, 19);
            lblInstrumento.TabIndex = 2;
            lblInstrumento.Text = "Instrumento:";
            //
            // cboInstrumento
            //
            cboInstrumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboInstrumento.FormattingEnabled = true;
            cboInstrumento.Location = new Point(110, 62);
            cboInstrumento.Name = "cboInstrumento";
            cboInstrumento.Size = new Size(320, 25);
            cboInstrumento.TabIndex = 3;
            cboInstrumento.SelectedIndexChanged += cboInstrumento_SelectedIndexChanged;
            //
            // lblPreco
            //
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(450, 65);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(55, 19);
            lblPreco.TabIndex = 4;
            lblPreco.Text = "Preço: -";
            //
            // lblEstoque
            //
            lblEstoque.AutoSize = true;
            lblEstoque.Location = new Point(450, 90);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(70, 19);
            lblEstoque.TabIndex = 5;
            lblEstoque.Text = "Estoque: -";
            //
            // lblQuantidade
            //
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(20, 105);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(76, 19);
            lblQuantidade.TabIndex = 6;
            lblQuantidade.Text = "Quantidade:";
            //
            // nudQuantidade
            //
            nudQuantidade.Location = new Point(110, 102);
            nudQuantidade.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantidade.Name = "nudQuantidade";
            nudQuantidade.Size = new Size(80, 25);
            nudQuantidade.TabIndex = 7;
            nudQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            //
            // btnAdicionar
            //
            btnAdicionar.Location = new Point(210, 99);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(140, 32);
            btnAdicionar.TabIndex = 8;
            btnAdicionar.Text = "Adicionar item";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            //
            // dgvItens
            //
            dgvItens.AllowUserToAddRows = false;
            dgvItens.AllowUserToDeleteRows = false;
            dgvItens.AutoGenerateColumns = false;
            dgvItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItens.Columns.AddRange(new DataGridViewColumn[] { colNome, colPreco, colQuantidade, colSubtotal });
            dgvItens.Location = new Point(20, 150);
            dgvItens.Name = "dgvItens";
            dgvItens.ReadOnly = true;
            dgvItens.RowHeadersVisible = false;
            dgvItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItens.Size = new Size(680, 250);
            dgvItens.TabIndex = 9;
            //
            // colNome
            //
            colNome.DataPropertyName = "Nome";
            colNome.FillWeight = 45F;
            colNome.HeaderText = "Instrumento";
            colNome.Name = "colNome";
            colNome.ReadOnly = true;
            //
            // colPreco
            //
            moedaStyle1.Format = "C2";
            colPreco.DataPropertyName = "PrecoUnitario";
            colPreco.DefaultCellStyle = moedaStyle1;
            colPreco.FillWeight = 20F;
            colPreco.HeaderText = "Preço Unit.";
            colPreco.Name = "colPreco";
            colPreco.ReadOnly = true;
            //
            // colQuantidade
            //
            colQuantidade.DataPropertyName = "Quantidade";
            colQuantidade.FillWeight = 10F;
            colQuantidade.HeaderText = "Qtd.";
            colQuantidade.Name = "colQuantidade";
            colQuantidade.ReadOnly = true;
            //
            // colSubtotal
            //
            moedaStyle2.Format = "C2";
            colSubtotal.DataPropertyName = "Subtotal";
            colSubtotal.DefaultCellStyle = moedaStyle2;
            colSubtotal.FillWeight = 25F;
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.Name = "colSubtotal";
            colSubtotal.ReadOnly = true;
            //
            // btnRemover
            //
            btnRemover.Location = new Point(20, 410);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(200, 32);
            btnRemover.TabIndex = 10;
            btnRemover.Text = "Remover item selecionado";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            //
            // lblTotal
            //
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotal.Location = new Point(480, 412);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(133, 25);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "Total: R$ 0,00";
            //
            // btnFinalizar
            //
            btnFinalizar.BackColor = Color.FromArgb(40, 140, 80);
            btnFinalizar.FlatStyle = FlatStyle.Flat;
            btnFinalizar.ForeColor = Color.White;
            btnFinalizar.Location = new Point(20, 465);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(200, 40);
            btnFinalizar.TabIndex = 12;
            btnFinalizar.Text = "Finalizar venda";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += btnFinalizar_Click;
            //
            // btnFechar
            //
            btnFechar.Location = new Point(500, 465);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(200, 40);
            btnFechar.TabIndex = 13;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            //
            // VendaForm
            //
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 520);
            Controls.Add(btnFechar);
            Controls.Add(btnFinalizar);
            Controls.Add(lblTotal);
            Controls.Add(btnRemover);
            Controls.Add(dgvItens);
            Controls.Add(btnAdicionar);
            Controls.Add(nudQuantidade);
            Controls.Add(lblQuantidade);
            Controls.Add(lblEstoque);
            Controls.Add(lblPreco);
            Controls.Add(cboInstrumento);
            Controls.Add(lblInstrumento);
            Controls.Add(txtCliente);
            Controls.Add(lblCliente);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VendaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Venda de Instrumentos";
            Load += VendaForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCliente;
        private TextBox txtCliente;
        private Label lblInstrumento;
        private ComboBox cboInstrumento;
        private Label lblPreco;
        private Label lblEstoque;
        private Label lblQuantidade;
        private NumericUpDown nudQuantidade;
        private Button btnAdicionar;
        private DataGridView dgvItens;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colPreco;
        private DataGridViewTextBoxColumn colQuantidade;
        private DataGridViewTextBoxColumn colSubtotal;
        private Button btnRemover;
        private Label lblTotal;
        private Button btnFinalizar;
        private Button btnFechar;
    }
}
