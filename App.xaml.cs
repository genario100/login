
namespace login
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            string? usuario_logado =  null;

            Task.Run(async () =>
            {
                usuario_logado = await SecureStorage.Default.GetAsync("Usuario_logado");

                if (usuario_logado == null)
                {
                    MainPage = new Login();
                }
                else
                {
                    MainPage = new Protegida();
                }
            }).Wait();
            
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return base.CreateWindow(activationState);
        }
        
    }

}
