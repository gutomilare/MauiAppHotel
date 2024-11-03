namespace MauiAppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new NavigationPage(new Sobre.Sobre()); buscar uma forma de implementar isso depois

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        } // Fecha método1

        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        } // Fecha método 2

    } // Fecha class

} // Fecha namespace
