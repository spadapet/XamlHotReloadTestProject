namespace MauiDemo;

public partial class AppShell : Shell
{
	public static ViewModel ViewModel { get; } = new();

	public AppShell()
	{
		InitializeComponent();
	}
}
