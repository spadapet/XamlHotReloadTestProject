using System.Collections.ObjectModel;

namespace MauiApp6.Controls;

public class ItemViewModel
{
    public string Title { get; } = Random.Shared.NextDouble().ToString();
}

public class NewContentViewModel
{
    public string Title { get; } = Random.Shared.NextDouble().ToString();
    public ObservableCollection<ItemViewModel> Items { get; } = new()
    {
        new ItemViewModel(),
        new ItemViewModel(),
        new ItemViewModel(),
    };
}

public partial class NewContent1 : ContentView
{
    public NewContentViewModel ViewModel { get; } = new();

    public NewContent1()
    {
        InitializeComponent();
    }
}