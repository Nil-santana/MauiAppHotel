using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {

        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
              Descricao = "Suite Super Luxo",
              ValorDiaraAdulto = 110.00,
              ValorDiaraCrianca = 55.00
            },
             new Quarto()
            {
              Descricao = "Suite Luxo",
              ValorDiaraAdulto = 80.00,
              ValorDiaraCrianca = 40.00
            },
              new Quarto()
            {
              Descricao = "Suite Sigle",
              ValorDiaraAdulto = 50.00,
              ValorDiaraCrianca = 25.00
            },
               new Quarto()
            {
              Descricao = "Suite Crise",
              ValorDiaraAdulto = 25.00,
              ValorDiaraCrianca = 12.5
            },
        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}
