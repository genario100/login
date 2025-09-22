using login.Class;
using Microsoft.VisualBasic;
using System.Threading.Tasks;

namespace login;

public partial class Login : ContentPage
{
    private object txtUsuario;

    public Login()
	{
		InitializeComponent();
	}

    private async  void Button_Clicked_2(object sender, EventArgs e)
    {
try
        {
            List<DadosUsuarios> lista_Usuarios = new List<DadosUsuarios>
            {
                new DadosUsuarios() { Usuario = "Genario", Senha = "54321" },
                new DadosUsuarios() { Usuario = "Maria", Senha = "12345" },
                new DadosUsuarios() { Usuario = "Joao", Senha = "67890" },
                new DadosUsuarios() { Usuario = "Ana", Senha = "54321" },
                new DadosUsuarios() { Usuario = "Pedro", Senha = "98765" }
            };

            DadosUsuarios dados_digitados = new DadosUsuarios()
            {
                Usuario = txt_Usuario.Text,
                Senha = txt_Senha.Text
            };
            //LINQ
            if (lista_Usuarios.Any(i => 
            dados_digitados.Usuario == i.Usuario &&
            dados_digitados.Senha == i.Senha))
            {
               await SecureStorage.Default.SetAsync("Usuario_logado", dados_digitados.Usuario);

                App.Current.MainPage = new Protegida();

            }else if (txt_Usuario.Text == null || txt_Senha.Text == null)
            {
               await DisplayAlert("Ops", "Preencha todos os campos", "Fechar");
                return;
            }
            else
            {
                throw new Exception("Usuario ou senha esta errado.");
            }
        }
        catch(Exception ex)
        {
            DisplayAlert("Ops", ex.Message , "Fechar");
        }
    }
}