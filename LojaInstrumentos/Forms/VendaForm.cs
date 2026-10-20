using LojaInstrumentos.Models;
using LojaInstrumentos.Services;


//Logica Carrinho de venda
namespace LojaInstrumentos.Forms
{
    public partial class VendaForm : Form
    {
        private readonly List<ItemVenda> _itens = new();

        public VendaForm()
        {
            InitializeComponent();
        }

        private void VendaForm_Load(object? sender, EventArgs e)
        {
            CarregarInstrumentos();
        }

        private Instrumento? InstrumentoSelecionado => cboInstrumento.SelectedItem as Instrumento;

        private void CarregarInstrumentos()
        {
            var disponiveis = Repositorio.Catalogo.Where(i => i.Estoque > 0).ToList();
            cboInstrumento.DataSource = disponiveis;
            cboInstrumento.DisplayMember = nameof(Instrumento.Nome);
            AtualizarInfoInstrumento();
        }

        private int QuantidadeJaNoCarrinho(int instrumentoId) =>
            _itens.Where(i => i.InstrumentoId == instrumentoId).Sum(i => i.Quantidade);

        private void AtualizarInfoInstrumento()
        {
            var instrumento = InstrumentoSelecionado;
            if (instrumento == null)
            {
                lblPreco.Text = "Preço: -";
                lblEstoque.Text = "Estoque: -";
                return;
            }

            var restante = instrumento.Estoque - QuantidadeJaNoCarrinho(instrumento.Id);
            lblPreco.Text = $"Preço: {instrumento.Preco:C2}";
            lblEstoque.Text = $"Estoque disponível: {restante}";
        }

        private void AtualizarGrid()
        {
            dgvItens.DataSource = null;
            dgvItens.DataSource = _itens.ToList();
            lblTotal.Text = $"Total: {_itens.Sum(i => i.Subtotal):C2}";
            AtualizarInfoInstrumento();
        }

        private void cboInstrumento_SelectedIndexChanged(object? sender, EventArgs e)
        {
            AtualizarInfoInstrumento();
        }

        private void btnAdicionar_Click(object? sender, EventArgs e)
        {
            var instrumento = InstrumentoSelecionado;
            if (instrumento == null)
            {
                MessageBox.Show("Selecione um instrumento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var quantidade = (int)nudQuantidade.Value;
            var restante = instrumento.Estoque - QuantidadeJaNoCarrinho(instrumento.Id);

            if (quantidade > restante)
            {
                MessageBox.Show($"Estoque insuficiente. Disponível: {restante}.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existente = _itens.FirstOrDefault(i => i.InstrumentoId == instrumento.Id);
            if (existente != null)
            {
                existente.Quantidade += quantidade;
            }
            else
            {
                _itens.Add(new ItemVenda
                {
                    InstrumentoId = instrumento.Id,
                    Nome = instrumento.Nome,
                    PrecoUnitario = instrumento.Preco,
                    Quantidade = quantidade
                });
            }

            nudQuantidade.Value = 1;
            AtualizarGrid();
        }

        private void btnRemover_Click(object? sender, EventArgs e)
        {
            if (dgvItens.CurrentRow?.DataBoundItem is ItemVenda item)
            {
                _itens.Remove(item);
                AtualizarGrid();
            }
        }

        private void btnFinalizar_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("Informe o nome do cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCliente.Focus();
                return;
            }

            if (_itens.Count == 0)
            {
                MessageBox.Show("Adicione ao menos um item à venda.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var venda = Repositorio.RegistrarVenda(txtCliente.Text.Trim(), _itens);

            MessageBox.Show($"Venda #{venda.Id} registrada com sucesso!\nTotal: {venda.Total:C2}",
                "Venda concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _itens.Clear();
            txtCliente.Clear();
            AtualizarGrid();
            CarregarInstrumentos();
        }

        private void btnFechar_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
