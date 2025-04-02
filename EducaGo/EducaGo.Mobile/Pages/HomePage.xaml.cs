namespace EducaGo.Mobile.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private async void Course1Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Pages.CoursesPage());
    }
}