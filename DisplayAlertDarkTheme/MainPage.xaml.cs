using System.Diagnostics;

namespace DisplayAlertDarkTheme;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnDisplayAlertClicked(object sender, EventArgs e)
    {
        bool answer = await DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
        Debug.WriteLine("Answer: " + answer);
    }
}
