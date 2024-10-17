namespace rtoasaS3B.Views;

public partial class Login : ContentPage
{
    string user="x", pass="x";
	public Login()
	{
		InitializeComponent();
	}
    public Login(string usuario, string contrasena)
    {
        InitializeComponent();
        user = usuario;
        pass = contrasena;
    }

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        if (user ==txtUsuario.Text && pass == txtContrasena.Text)
        {
            Navigation.PushAsync(new Views.Home());
        }
        else
        {
            DisplayAlert("ERROR", "Usuario/Contrasena Incorrectos", "Cerrar");
        }
    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.Registro());
    }
}