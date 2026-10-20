using LojaInstrumentos.Models;
using LojaInstrumentos.Services;

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
        	
        }

        private Instrumento? InstrumentoSelecionado => cboInstrumento.SelectedItem as Instrumento;

        private void CarregarInstrumentos()
        {
            
        }

        private int QuantidadeJaNoCarrinho(int instrumentoId) =>
            _itens.Where(i => i.InstrumentoId == instrumentoId).Sum(i => i.Quantidade);

        private void AtualizarInfoInstrumento()
        {
            
        }

        private void AtualizarGrid()
        {
            
        }

        private void cboInstrumento_SelectedIndexChanged(object? sender, EventArgs e)
        {
            
        }

        private void btnAdicionar_Click(object? sender, EventArgs e)
        {
            
        }

        private void btnRemover_Click(object? sender, EventArgs e)
        {
            
        }

        private void btnFinalizar_Click(object? sender, EventArgs e)
        {
            
        }

        private void btnFechar_Click(object? sender, EventArgs e)
        {
            
        }
    }
}
