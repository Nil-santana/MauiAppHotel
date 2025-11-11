namespace MauiAppHotel.Models
{
    public class Hospedagem
    {
        public Quarto QuartoSelecionado { get; set; }
        public int QntAdultos {  get; set; }
        public int QntCrianças { get; set; }
        public DateTime DataCheckin { get; set; }
        public DateTime DataCheckout { get; set; }
        public int Estadia
        {
            get => DataCheckout.Subtract(DataCheckin).Days;
        }public double ValorTotal
        {
            get
            {
                double valor_adultos = QntAdultos * QuartoSelecionado.ValorDiaraAdulto;
                double valor_criança = QntCrianças * QuartoSelecionado.ValorDiaraCrianca;

                double total = (valor_adultos + valor_criança) * Estadia;

                return total;
            }
        }

    }
}
