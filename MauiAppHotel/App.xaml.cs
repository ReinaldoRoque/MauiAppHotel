using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto
            {
                Descricao = "Suíte Super Luxo",
                ValorDiariaAdulto = 110.0,
                ValorDariaCrianca = 55.0
            },
            new Quarto
            {
                Descricao = "Suíte Luxo",
                ValorDiariaAdulto = 80.0,
                ValorDariaCrianca = 40.0
            },
            new Quarto
            {
                Descricao = "Suíte Single",
                ValorDiariaAdulto = 50,
                ValorDariaCrianca = 25
            },
            new Quarto
            {
                Descricao = "Suíte Crise",
                ValorDiariaAdulto = 25,
                ValorDariaCrianca = 12.5
            }
        }; 
        public App()
        {
            InitializeComponent();

             MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
            //MainPage = new NavigationPage(new Views.Sobre());
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
