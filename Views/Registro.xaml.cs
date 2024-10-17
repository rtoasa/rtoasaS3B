namespace rtoasaS3B.Views;

public partial class Registro : ContentPage
{
	public Registro()
	{
		InitializeComponent();
	}

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
		string usuario = txtUsuarior.Text;
		string contrasena = txtContrasenar.Text;

		Navigation.PushAsync(new Views.Login(usuario, contrasena));


    }
}