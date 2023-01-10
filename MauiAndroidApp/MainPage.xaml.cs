using Microsoft.Maui.ApplicationModel.Communication;

namespace MauiAndroidApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";
		SemanticScreenReader.Announce(CounterBtn.Text);
		if(count == 3)
			Navigation.PushAsync(new Employees());
		Console.WriteLine("test!");
    }
}

