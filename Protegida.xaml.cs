//using Java.Util;
using login.Class;

namespace login;

public partial class Protegida : ContentPage
{
	public Protegida()
	{
		InitializeComponent();

        string? usuarioLogado = null;
        
        Task.Run(async () =>
        {
            usuarioLogado = await SecureStorage.Default.GetAsync("Usuario_logado");
           lbl_boasvindas.Text = $"Bem vindo(a), {usuarioLogado}";
            //user_logado();

        }).Wait();

    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        bool confirmasao = await DisplayAlert("Tem certesa?", "Sair do app?", "Sim", "Não");
        if (confirmasao)
        {
            SecureStorage.Default.Remove("Usuario_logado");
            App.Current.MainPage = new Login();
        }
    }
}