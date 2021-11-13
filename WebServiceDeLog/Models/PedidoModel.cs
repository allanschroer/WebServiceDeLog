using WebServiceDeLog.Enums;

namespace WebServiceDeLog.Models
{
    public class PedidoModel
    {
        public int IdPedido { get; set; }
        public int NumeroPedidoControle { get; set; }
        public int NumeroPedidoEntrega { get; set; }
        public List<ProdutoModel> Produtos { get; set; }
        public ClienteModel Cliente { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataHoraEntrega { get; set; }
        public int CodigoColaboradorEntrega { get; set; }
        public SituacaoEnum Situacao { get; set; }
    }
}
