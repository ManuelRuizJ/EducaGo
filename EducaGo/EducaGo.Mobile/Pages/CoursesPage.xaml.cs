using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;


namespace EducaGo.Mobile.Pages;

public partial class CoursesPage : ContentPage
{
    public CoursesPage()
	{
		InitializeComponent();
    }

    private async void LessonClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Pages.LessonPage());
    }
}