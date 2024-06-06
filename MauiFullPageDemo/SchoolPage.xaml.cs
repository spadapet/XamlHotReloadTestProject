namespace MauiDemo;

public partial class SchoolPage : ContentPage
{
	int count = 0;

	public SchoolPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		// VSCode DEMO: Increment by 1 instead of 10
		count += 10;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

