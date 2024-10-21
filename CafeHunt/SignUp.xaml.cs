namespace CafeHunt;

public partial class SignUp : ContentPage
{
	public SignUp()
	{
		InitializeComponent();
	}

	private async void Login_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MainPage());
	}
}