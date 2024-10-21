namespace CafeHunt
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void ForgotPassword_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ForgotPassword());
        }

        private async void SignUp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OnBoarding());
        }

        private async void BTNLogin_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Home());
        }
    }

}
