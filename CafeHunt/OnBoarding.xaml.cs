namespace CafeHunt;

public partial class OnBoarding : ContentPage
{
	public OnBoarding()
	{
		InitializeComponent();
	}

    private async void BTNPersonal_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SignUp());
    }

    private async void BTNBusiness_Clicked(object sender, EventArgs e)
    {

    }
}